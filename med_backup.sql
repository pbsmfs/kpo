--
-- PostgreSQL database dump
--

\restrict 2cI99YIrarXOTfxjG3dOHaxtTAIz36AOQdNk7BOGCNiUzB1OiEY29fpAyn4hQw1

-- Dumped from database version 15.14
-- Dumped by pg_dump version 15.14

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: gender_enum; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.gender_enum AS ENUM (
    'MALE',
    'FEMALE',
    'OTHER'
);


ALTER TYPE public.gender_enum OWNER TO postgres;

--
-- Name: find_examination_results_by_type(uuid, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.find_examination_results_by_type(patient_uuid uuid, search_exam_type character varying) RETURNS TABLE(exam_type character varying, result text, parameters jsonb, creation_date date, author_username character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT 
        er.exam_type, 
        er.result, 
        er.parameters, 
        md.creation_date,
        u.username as author_username
    FROM examination_results er
    JOIN medical_documents md ON er.medical_document_id = md.id
    JOIN patient_cards pc ON md.patient_card_id = pc.id
    JOIN users u ON md.author_id = u.id
    WHERE pc.patient_id = patient_uuid AND er.exam_type ILIKE '%' || search_exam_type || '%';
END;
$$;


ALTER FUNCTION public.find_examination_results_by_type(patient_uuid uuid, search_exam_type character varying) OWNER TO postgres;

--
-- Name: get_patient_card_users(uuid); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_patient_card_users(patient_card_uuid uuid) RETURNS TABLE(user_id uuid, username character varying, access_level character varying, granted_at timestamp without time zone)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY
    SELECT 
        u.id, 
        u.username, 
        upca.access_level, 
        upca.granted_at
    FROM user_patient_card_access upca
    JOIN users u ON upca.user_id = u.id
    WHERE upca.patient_card_id = patient_card_uuid;
END;
$$;


ALTER FUNCTION public.get_patient_card_users(patient_card_uuid uuid) OWNER TO postgres;

--
-- Name: get_patient_full_name(uuid); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_patient_full_name(patient_uuid uuid) RETURNS text
    LANGUAGE plpgsql
    AS $$
DECLARE
    full_name TEXT;
BEGIN
    SELECT CONCAT(first_name, ' ', last_name) INTO full_name
    FROM patients WHERE id = patient_uuid;
    RETURN full_name;
END;
$$;


ALTER FUNCTION public.get_patient_full_name(patient_uuid uuid) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: examination_results; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.examination_results (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    medical_document_id uuid NOT NULL,
    exam_type character varying(100) NOT NULL,
    result text,
    parameters jsonb,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.examination_results OWNER TO postgres;

--
-- Name: medical_documents; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.medical_documents (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    author_id uuid NOT NULL,
    patient_card_id uuid NOT NULL,
    creation_date date DEFAULT CURRENT_DATE NOT NULL,
    document_type character varying(50) NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT medical_documents_document_type_check CHECK (((document_type)::text = ANY ((ARRAY['MEDICAL_RECORD'::character varying, 'EXAMINATION_RESULT'::character varying])::text[])))
);


ALTER TABLE public.medical_documents OWNER TO postgres;

--
-- Name: patient_cards; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.patient_cards (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    patient_id uuid NOT NULL,
    method_date date DEFAULT CURRENT_DATE NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.patient_cards OWNER TO postgres;

--
-- Name: patients; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.patients (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    first_name character varying(100) NOT NULL,
    last_name character varying(100) NOT NULL,
    phone_number character varying(20),
    address text,
    email character varying(255),
    gender public.gender_enum,
    birthday date,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.patients OWNER TO postgres;

--
-- Name: examination_results_by_type; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.examination_results_by_type AS
 SELECT er.id,
    er.medical_document_id,
    er.exam_type,
    er.result,
    er.parameters,
    er.created_at,
    pc.patient_id,
    p.first_name,
    p.last_name,
    md.creation_date
   FROM (((public.examination_results er
     JOIN public.medical_documents md ON ((er.medical_document_id = md.id)))
     JOIN public.patient_cards pc ON ((md.patient_card_id = pc.id)))
     JOIN public.patients p ON ((pc.patient_id = p.id)));


ALTER TABLE public.examination_results_by_type OWNER TO postgres;

--
-- Name: medical_records; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.medical_records (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    medical_document_id uuid NOT NULL,
    diagnosis text NOT NULL,
    symptoms text,
    treatment_plan text,
    completed boolean DEFAULT false,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.medical_records OWNER TO postgres;

--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    username character varying(100) NOT NULL,
    first_name character varying(100) NOT NULL,
    last_name character varying(100) NOT NULL,
    email character varying(255),
    role character varying(50),
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: last_medical_documents; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.last_medical_documents AS
 SELECT pc.patient_id,
    md.id AS medical_document_id,
    md.document_type,
    md.creation_date,
        CASE
            WHEN ((md.document_type)::text = 'MEDICAL_RECORD'::text) THEN mr.diagnosis
            WHEN ((md.document_type)::text = 'EXAMINATION_RESULT'::text) THEN (er.exam_type)::text
            ELSE NULL::text
        END AS description,
    u.username AS author_username
   FROM ((((public.medical_documents md
     JOIN public.patient_cards pc ON ((md.patient_card_id = pc.id)))
     JOIN public.users u ON ((md.author_id = u.id)))
     LEFT JOIN public.medical_records mr ON (((md.id = mr.medical_document_id) AND ((md.document_type)::text = 'MEDICAL_RECORD'::text))))
     LEFT JOIN public.examination_results er ON (((md.id = er.medical_document_id) AND ((md.document_type)::text = 'EXAMINATION_RESULT'::text))));


ALTER TABLE public.last_medical_documents OWNER TO postgres;

--
-- Name: medical_document_comments; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.medical_document_comments (
    id uuid DEFAULT gen_random_uuid() NOT NULL,
    medical_document_id uuid NOT NULL,
    author_id uuid NOT NULL,
    comment_text text NOT NULL,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.medical_document_comments OWNER TO postgres;

--
-- Name: user_patient_card_access; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.user_patient_card_access (
    user_id uuid NOT NULL,
    patient_card_id uuid NOT NULL,
    access_level character varying(50) DEFAULT 'READ'::character varying,
    granted_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public.user_patient_card_access OWNER TO postgres;

--
-- Data for Name: examination_results; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.examination_results (id, medical_document_id, exam_type, result, parameters, created_at) FROM stdin;
747594ec-6c4f-4c81-b69f-869b755ef37a	a63139eb-144a-4d22-acfc-b65fe72c61b5	Общий анализ крови	В пределах нормы	{"СОЭ": "12 мм/ч", "лейкоциты": "6.8 × 10^9/л", "гемоглобин": "145 г/л"}	2025-11-19 14:45:03.784076
57f77e03-3cc9-41b3-ab1c-0eff932eb677	5058cf19-2731-4424-be24-68a0cd363e1c	Биохимический анализ крови	Повышены печеночные ферменты	{"АЛТ": "68 Ед/л", "АСТ": "45 Ед/л", "глюкоза": "5.8 ммоль/л"}	2025-11-19 14:45:03.80007
164586ca-c35d-4e93-9e4e-b48490ef5b10	846ee3a5-ffbe-43fb-9032-c50b03f8f6ef	ЭКГ	Синусовый ритм, норма	{"ЧСС": "72 уд/мин", "интервал PQ": "0.16 с", "комплекс QRS": "0.08 с"}	2025-11-19 14:45:03.805863
43b2cb39-f1ab-426f-aa09-c576239f9eac	1363eba5-350d-4625-b8e7-b3face323313	УЗИ брюшной полости	Признаки хронического холецистита	{"печень": "норма", "поджелудочная": "норма", "желчный пузырь": "утолщены стенки"}	2025-11-19 14:45:03.807938
ad7c548e-8adf-4998-b1c4-a5fd5281c9b6	c34abdcb-83f3-467b-8fa2-cbf26fb1994f	Рентген грудной клетки	Без патологий	{"сердце": "нормальных размеров", "диафрагма": "ровная", "легочные поля": "чистые"}	2025-11-19 14:45:03.809288
d6bbf24e-14be-4345-9e9f-a6faffa26eee	17f7f6c9-3e65-405a-b679-e86026d7af5c	МРТ головного мозга	Очаговых изменений не выявлено	{"желудочки": "нормальных размеров", "вещество мозга": "без особенностей", "субарахноидальные пространства": "не расширены"}	2025-11-19 14:45:03.810404
990ee612-1e7c-465a-89bd-db195bb438f1	312c880a-318a-4b75-83cc-da7473006d67	Анализ мочи	В пределах нормы	{"цвет": "соломенно-желтый", "белок": "отсутствует", "глюкоза": "отсутствует", "лейкоциты": "2-3 в поле зрения"}	2025-11-19 14:45:03.812009
db1bee96-c9d8-4f3b-be65-86bb45b111cd	3b3ec38d-c7b2-44f7-8b46-f22d316980e7	УЗИ щитовидной железы	Диффузные изменения	{"узлы": "не выявлены", "размеры": "увеличены", "структура": "неоднородная"}	2025-11-19 14:45:03.813198
6a86dac2-5cfe-498d-af97-be9c9999af25	fcb53617-3470-4b77-b977-4ea5c87e89c4	ФГДС	Поверхностный гастрит	{"желудок": "слизистая гиперемирована", "пищевод": "проходим", "12-перстная кишка": "без особенностей"}	2025-11-19 14:45:03.814297
52204b6d-6025-4673-8c54-4d73302d7fc6	c23e7489-14f5-4751-9431-4a5a73c04bde	КТ позвоночника	Остеохондроз L4-L5	{"позвонки": "дегенеративные изменения", "спинной мозг": "без компрессии", "межпозвонковые диски": "снижение высоты"}	2025-11-19 14:45:03.815311
\.


--
-- Data for Name: medical_document_comments; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.medical_document_comments (id, medical_document_id, author_id, comment_text, created_at) FROM stdin;
fef673d8-76cf-43ac-939b-e9f1b391612c	cf5c2363-b4a8-4e9b-aa18-79b5fc0a5a55	94c3af54-d9b0-4e65-a32e-a0a371557af0	Пациенту рекомендован повторный осмотр через 7 дней	2025-11-19 14:45:03.818784
dc982c99-c271-490e-b152-43e906c72d44	8c8f7996-f04b-42d6-bda4-1e9bf43f2722	c919449c-3b7f-420c-abef-370555355468	Контроль АД утром и вечером, запись в дневник	2025-11-19 14:45:03.818784
95ca6768-9a5e-41f4-97ea-212641560b0b	852c3c34-14e3-41b9-9e96-bdb56183570a	d1521789-9cf5-4c31-b1fc-c55050b20098	Назначена консультация эндокринолога	2025-11-19 14:45:03.818784
b58af494-9b9d-45e9-a9d7-d0d61c1fc13c	4ca037e4-9628-4df6-bdc0-b0a84624f714	94c3af54-d9b0-4e65-a32e-a0a371557af0	Пациент направлен на ЛФК в поликлинику по месту жительства	2025-11-19 14:45:03.818784
d696e3b8-892e-4be4-a21e-3b59d4b78f07	fc315533-93e4-40df-b956-105e3a6726bb	c919449c-3b7f-420c-abef-370555355468	Рекомендована диета №1, исключение острой и жареной пищи	2025-11-19 14:45:03.818784
cfb1024f-3f0e-44b7-b3a4-1dab92398447	c3bf0f13-34bd-4031-8bb0-2996202dccc7	d1521789-9cf5-4c31-b1fc-c55050b20098	Контроль общего анализа крови через 1 месяц	2025-11-19 14:45:03.818784
ff81afe3-fc6e-4fb3-a595-cefef346aa5a	b766a304-8726-4bd2-8f12-18dc6b19711e	94c3af54-d9b0-4e65-a32e-a0a371557af0	Симптомы купированы, лечение завершено	2025-11-19 14:45:03.818784
de71de76-3746-4879-be17-23a9874a3b8b	119400e4-e57e-4440-a29f-671ab124bfc4	c919449c-3b7f-420c-abef-370555355468	Рекомендованы пробы на аллергены	2025-11-19 14:45:03.818784
19b99780-6f32-4a3d-8b7a-10c2c6abcf46	f3152242-8b52-44c6-8720-02bfb22c678a	d1521789-9cf5-4c31-b1fc-c55050b20098	Пациенту выдан больничный лист на 3 дня	2025-11-19 14:45:03.818784
491cedb6-80b4-4cea-98f5-8e9814fe70ff	97995002-aa3a-4fb8-ac52-2322928a5e0c	94c3af54-d9b0-4e65-a32e-a0a371557af0	Назначена консультация травматолога-ортопеда	2025-11-19 14:45:03.818784
08bc94bd-1f51-466d-bc75-101f38b538a0	a63139eb-144a-4d22-acfc-b65fe72c61b5	200980f1-3307-4d2f-947a-1ba8c6abb112	Анализ в норме, дополнительные исследования не требуются	2025-11-19 14:45:03.825523
1a0292d1-863e-4c2f-b0f0-16dd34f13980	5058cf19-2731-4424-be24-68a0cd363e1c	735a1b75-7f24-4c00-93e6-2ff0f2f60271	Рекомендован контроль печеночных ферментов через 2 недели	2025-11-19 14:45:03.825523
2ac40637-3038-4cde-a482-67c05186e370	846ee3a5-ffbe-43fb-9032-c50b03f8f6ef	bb4aa680-e597-40ab-ae83-c687e3fbf655	ЭКГ без патологий, ритм регулярный	2025-11-19 14:45:03.825523
9eada84f-4913-4e7a-9004-dfd130f5e5ad	1363eba5-350d-4625-b8e7-b3face323313	200980f1-3307-4d2f-947a-1ba8c6abb112	Рекомендована консультация гастроэнтеролога	2025-11-19 14:45:03.825523
87cc1a7f-62cf-42a7-aa54-3c753e483d1d	c34abdcb-83f3-467b-8fa2-cbf26fb1994f	f45f7d5a-6393-43d9-acc7-f517d9d390f8	Рентгенограмма без особенностей	2025-11-19 14:45:03.825523
033acbd7-d568-45bd-b951-c882e7f4d812	17f7f6c9-3e65-405a-b679-e86026d7af5c	dacfb38a-e2c1-4df6-8a6a-6744940cc9f8	МРТ подтверждает отсутствие органической патологии	2025-11-19 14:45:03.825523
3e77ec28-4e41-4540-8863-ace8a635aae9	312c880a-318a-4b75-83cc-da7473006d67	86995f45-e9b6-4a67-8551-d3ebcd438f64	Анализ мочи соответствует норме	2025-11-19 14:45:03.825523
e14b86bf-50bb-4469-a276-7cefa5c43047	3b3ec38d-c7b2-44f7-8b46-f22d316980e7	200980f1-3307-4d2f-947a-1ba8c6abb112	Назначена консультация эндокринолога	2025-11-19 14:45:03.825523
6107331f-f6cd-43e1-96ad-8c92bb577b27	fcb53617-3470-4b77-b977-4ea5c87e89c4	735a1b75-7f24-4c00-93e6-2ff0f2f60271	Рекомендована повторная ФГДС через 6 месяцев	2025-11-19 14:45:03.825523
a9487705-d5d8-40cc-a4d2-d60f1d41eb53	c23e7489-14f5-4751-9431-4a5a73c04bde	bb4aa680-e597-40ab-ae83-c687e3fbf655	КТ подтверждает диагноз остеохондроза	2025-11-19 14:45:03.825523
\.


--
-- Data for Name: medical_documents; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.medical_documents (id, author_id, patient_card_id, creation_date, document_type, created_at) FROM stdin;
cf5c2363-b4a8-4e9b-aa18-79b5fc0a5a55	200980f1-3307-4d2f-947a-1ba8c6abb112	c4049267-6938-45a4-8f1f-07eb8d793256	2024-01-15	MEDICAL_RECORD	2025-11-19 14:41:12.65375
8c8f7996-f04b-42d6-bda4-1e9bf43f2722	735a1b75-7f24-4c00-93e6-2ff0f2f60271	28ea86c9-85c7-4560-b62f-1e63c2f240cb	2024-01-16	MEDICAL_RECORD	2025-11-19 14:41:12.65375
852c3c34-14e3-41b9-9e96-bdb56183570a	bb4aa680-e597-40ab-ae83-c687e3fbf655	92719e11-6544-491e-a0f6-355e5439fdc2	2024-01-17	MEDICAL_RECORD	2025-11-19 14:41:12.65375
4ca037e4-9628-4df6-bdc0-b0a84624f714	200980f1-3307-4d2f-947a-1ba8c6abb112	52f46f63-fd91-492a-9ab4-84b670fc6a84	2024-01-18	MEDICAL_RECORD	2025-11-19 14:41:12.65375
fc315533-93e4-40df-b956-105e3a6726bb	f45f7d5a-6393-43d9-acc7-f517d9d390f8	f9608cbf-71be-4367-91cf-d92b6bbab4c2	2024-01-19	MEDICAL_RECORD	2025-11-19 14:41:12.65375
c3bf0f13-34bd-4031-8bb0-2996202dccc7	dacfb38a-e2c1-4df6-8a6a-6744940cc9f8	daf29ced-f928-4756-bfb6-34a0d24a4fc0	2024-01-20	MEDICAL_RECORD	2025-11-19 14:41:12.65375
b766a304-8726-4bd2-8f12-18dc6b19711e	86995f45-e9b6-4a67-8551-d3ebcd438f64	ac0e7b2f-bf1b-4ce0-8e37-2f3629c6f635	2024-01-21	MEDICAL_RECORD	2025-11-19 14:41:12.65375
119400e4-e57e-4440-a29f-671ab124bfc4	200980f1-3307-4d2f-947a-1ba8c6abb112	22df4765-a802-4445-9f4f-dd4d5b5def1d	2024-01-22	MEDICAL_RECORD	2025-11-19 14:41:12.65375
f3152242-8b52-44c6-8720-02bfb22c678a	735a1b75-7f24-4c00-93e6-2ff0f2f60271	e67b1492-c9ef-4e11-837d-ff275f6377f6	2024-01-23	MEDICAL_RECORD	2025-11-19 14:41:12.65375
97995002-aa3a-4fb8-ac52-2322928a5e0c	bb4aa680-e597-40ab-ae83-c687e3fbf655	a02d09b4-ad32-4bc8-8174-02863f7b4a36	2024-01-24	MEDICAL_RECORD	2025-11-19 14:41:12.65375
a63139eb-144a-4d22-acfc-b65fe72c61b5	200980f1-3307-4d2f-947a-1ba8c6abb112	c4049267-6938-45a4-8f1f-07eb8d793256	2024-01-15	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
5058cf19-2731-4424-be24-68a0cd363e1c	735a1b75-7f24-4c00-93e6-2ff0f2f60271	28ea86c9-85c7-4560-b62f-1e63c2f240cb	2024-01-16	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
846ee3a5-ffbe-43fb-9032-c50b03f8f6ef	bb4aa680-e597-40ab-ae83-c687e3fbf655	92719e11-6544-491e-a0f6-355e5439fdc2	2024-01-17	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
1363eba5-350d-4625-b8e7-b3face323313	200980f1-3307-4d2f-947a-1ba8c6abb112	52f46f63-fd91-492a-9ab4-84b670fc6a84	2024-01-18	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
c34abdcb-83f3-467b-8fa2-cbf26fb1994f	f45f7d5a-6393-43d9-acc7-f517d9d390f8	f9608cbf-71be-4367-91cf-d92b6bbab4c2	2024-01-19	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
17f7f6c9-3e65-405a-b679-e86026d7af5c	dacfb38a-e2c1-4df6-8a6a-6744940cc9f8	daf29ced-f928-4756-bfb6-34a0d24a4fc0	2024-01-20	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
312c880a-318a-4b75-83cc-da7473006d67	86995f45-e9b6-4a67-8551-d3ebcd438f64	ac0e7b2f-bf1b-4ce0-8e37-2f3629c6f635	2024-01-21	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
3b3ec38d-c7b2-44f7-8b46-f22d316980e7	200980f1-3307-4d2f-947a-1ba8c6abb112	22df4765-a802-4445-9f4f-dd4d5b5def1d	2024-01-22	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
fcb53617-3470-4b77-b977-4ea5c87e89c4	735a1b75-7f24-4c00-93e6-2ff0f2f60271	e67b1492-c9ef-4e11-837d-ff275f6377f6	2024-01-23	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
c23e7489-14f5-4751-9431-4a5a73c04bde	bb4aa680-e597-40ab-ae83-c687e3fbf655	a02d09b4-ad32-4bc8-8174-02863f7b4a36	2024-01-24	EXAMINATION_RESULT	2025-11-19 14:41:12.657992
\.


--
-- Data for Name: medical_records; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.medical_records (id, medical_document_id, diagnosis, symptoms, treatment_plan, completed, created_at, updated_at) FROM stdin;
e423939b-5e86-4e72-b013-e456de5cb989	cf5c2363-b4a8-4e9b-aa18-79b5fc0a5a55	Острый бронхит	Кашель, температура 38.5°C, слабость	Антибиотики, противокашлевые средства, постельный режим	t	2025-11-19 14:41:12.659312	2025-11-19 14:41:12.659312
82bb7f6e-baf4-437d-bb6e-1ef8f0af6a84	8c8f7996-f04b-42d6-bda4-1e9bf43f2722	Гипертоническая болезнь	Головная боль, головокружение, АД 150/95	Гипотензивные препараты, диета, контроль АД	f	2025-11-19 14:41:12.660536	2025-11-19 14:41:12.660536
cde46765-9878-4cda-95e7-c5fa0796d7a3	852c3c34-14e3-41b9-9e96-bdb56183570a	Сахарный диабет 2 типа	Жажда, частое мочеиспускание, утомляемость	Диета, метформин, контроль глюкозы	f	2025-11-19 14:41:12.661482	2025-11-19 14:41:12.661482
89abe0b9-93f7-4d42-b269-9df12a833665	4ca037e4-9628-4df6-bdc0-b0a84624f714	Остеохондроз позвоночника	Боль в спине, ограничение движений	ЛФК, физиотерапия, НПВП	t	2025-11-19 14:41:12.662256	2025-11-19 14:41:12.662256
f0d0bf54-0892-45a2-a27c-2b795664a4da	fc315533-93e4-40df-b956-105e3a6726bb	Гастрит	Боль в эпигастрии, тошнота, изжога	Диета, антациды, ингибиторы протонной помпы	t	2025-11-19 14:41:12.663247	2025-11-19 14:41:12.663247
c299be8a-1d63-401a-bacc-dd443975f021	c3bf0f13-34bd-4031-8bb0-2996202dccc7	Анемия	Слабость, бледность, головокружение	Препараты железа, витамины, диета	f	2025-11-19 14:41:12.664247	2025-11-19 14:41:12.664247
8303c78c-ee86-4f0a-8971-b3f0fcd6df68	b766a304-8726-4bd2-8f12-18dc6b19711e	ОРВИ	Насморк, боль в горле, температура 37.8°C	Противовирусные, обильное питье, покой	t	2025-11-19 14:41:12.665238	2025-11-19 14:41:12.665238
e608ae98-8e07-46b8-8534-8716b8f0beac	119400e4-e57e-4440-a29f-671ab124bfc4	Аллергический ринит	Чихание, зуд в носу, заложенность	Антигистаминные, назальные спреи	f	2025-11-19 14:41:12.666528	2025-11-19 14:41:12.666528
2d2c9ed7-5f6c-425a-a8ae-c1dda0f3ae0d	f3152242-8b52-44c6-8720-02bfb22c678a	Мигрень	Головная боль, тошнота, светобоязнь	Обезболивающие, покой, исключение триггеров	t	2025-11-19 14:41:12.667431	2025-11-19 14:41:12.667431
acf43a01-2d17-417f-a3a8-e29350fd8ffb	97995002-aa3a-4fb8-ac52-2322928a5e0c	Артрит коленного сустава	Боль в колене, отек, ограничение движений	НПВП, физиотерапия, внутрисуставные инъекции	f	2025-11-19 14:41:12.668387	2025-11-19 14:41:12.668387
\.


--
-- Data for Name: patient_cards; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.patient_cards (id, patient_id, method_date, created_at, updated_at) FROM stdin;
c4049267-6938-45a4-8f1f-07eb8d793256	005b9be5-2186-4270-a143-cfacbd0cf1f7	2024-01-15	2025-11-19 14:41:12.642043	2025-11-19 14:41:12.642043
28ea86c9-85c7-4560-b62f-1e63c2f240cb	0318c502-2f3b-44e0-983e-6b2e02fc594b	2024-01-16	2025-11-19 14:41:12.643305	2025-11-19 14:41:12.643305
92719e11-6544-491e-a0f6-355e5439fdc2	2a8fd30d-1623-4441-99be-80b5595381e9	2024-01-17	2025-11-19 14:41:12.644086	2025-11-19 14:41:12.644086
52f46f63-fd91-492a-9ab4-84b670fc6a84	571fab12-f6a0-4790-ab08-6ea5d6a3f7dc	2024-01-18	2025-11-19 14:41:12.645196	2025-11-19 14:41:12.645196
f9608cbf-71be-4367-91cf-d92b6bbab4c2	57671ef8-4cd2-43f0-bbe9-e0c2e00b997c	2024-01-19	2025-11-19 14:41:12.645947	2025-11-19 14:41:12.645947
daf29ced-f928-4756-bfb6-34a0d24a4fc0	73729107-3291-4b6c-bcc5-9ea5ef639131	2024-01-20	2025-11-19 14:41:12.646761	2025-11-19 14:41:12.646761
ac0e7b2f-bf1b-4ce0-8e37-2f3629c6f635	a79d0897-f83f-490e-a441-78630d134c4a	2024-01-21	2025-11-19 14:41:12.648127	2025-11-19 14:41:12.648127
22df4765-a802-4445-9f4f-dd4d5b5def1d	aae9acac-6fa7-40d0-b36c-212380b67451	2024-01-22	2025-11-19 14:41:12.649014	2025-11-19 14:41:12.649014
e67b1492-c9ef-4e11-837d-ff275f6377f6	c1f6de45-2b43-41a5-9c79-334cc9650378	2024-01-23	2025-11-19 14:41:12.649886	2025-11-19 14:41:12.649886
a02d09b4-ad32-4bc8-8174-02863f7b4a36	d2224822-9848-46ba-83f5-7dfcf2d86b78	2024-01-24	2025-11-19 14:41:12.650606	2025-11-19 14:41:12.650606
\.


--
-- Data for Name: patients; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.patients (id, first_name, last_name, phone_number, address, email, gender, birthday, created_at, updated_at) FROM stdin;
d2224822-9848-46ba-83f5-7dfcf2d86b78	Иван	Петров	+79161234567	Москва, ул. Ленина, д. 15, кв. 34	ivan.petrov@mail.ru	MALE	1985-03-15	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
0318c502-2f3b-44e0-983e-6b2e02fc594b	Мария	Сидорова	+79162345678	Санкт-Петербург, Невский пр., д. 42	maria.sidorova@gmail.com	FEMALE	1990-07-22	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
73729107-3291-4b6c-bcc5-9ea5ef639131	Алексей	Козлов	+79163456789	Екатеринбург, ул. Мира, д. 7, кв. 12	alex.kozlov@yandex.ru	MALE	1978-11-03	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
571fab12-f6a0-4790-ab08-6ea5d6a3f7dc	Ольга	Иванова	+79164567890	Новосибирск, пр. Карла Маркса, д. 33	olga.ivanova@mail.ru	FEMALE	1982-05-18	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
005b9be5-2186-4270-a143-cfacbd0cf1f7	Дмитрий	Смирнов	+79165678901	Казань, ул. Баумана, д. 24	dmitry.smirnov@gmail.com	MALE	1995-12-30	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
c1f6de45-2b43-41a5-9c79-334cc9650378	Елена	Кузнецова	+79166789012	Ростов-на-Дону, ул. Садовая, д. 56	elena.kuznetsova@mail.ru	FEMALE	1988-09-14	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
2a8fd30d-1623-4441-99be-80b5595381e9	Сергей	Попов	+79167890123	Владивосток, ул. Светланская, д. 89	sergey.popov@yandex.ru	MALE	1975-02-28	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
aae9acac-6fa7-40d0-b36c-212380b67451	Анна	Васильева	+79168901234	Краснодар, ул. Красная, д. 112	anna.vasileva@gmail.com	FEMALE	1992-04-11	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
57671ef8-4cd2-43f0-bbe9-e0c2e00b997c	Павел	Федоров	+79169012345	Сочи, ул. Навагинская, д. 17	pavel.fedorov@mail.ru	MALE	1980-08-07	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
a79d0897-f83f-490e-a441-78630d134c4a	Наталья	Морозова	+79160123456	Калининград, Ленинский пр., д. 63	natalia.morozova@yandex.ru	FEMALE	1987-06-25	2025-11-19 14:41:12.638923	2025-11-19 14:41:12.638923
\.


--
-- Data for Name: user_patient_card_access; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.user_patient_card_access (user_id, patient_card_id, access_level, granted_at) FROM stdin;
200980f1-3307-4d2f-947a-1ba8c6abb112	c4049267-6938-45a4-8f1f-07eb8d793256	READ_WRITE	2025-11-19 14:45:03.831152
735a1b75-7f24-4c00-93e6-2ff0f2f60271	28ea86c9-85c7-4560-b62f-1e63c2f240cb	READ_WRITE	2025-11-19 14:45:03.831152
bb4aa680-e597-40ab-ae83-c687e3fbf655	92719e11-6544-491e-a0f6-355e5439fdc2	READ_WRITE	2025-11-19 14:45:03.831152
94c3af54-d9b0-4e65-a32e-a0a371557af0	52f46f63-fd91-492a-9ab4-84b670fc6a84	READ	2025-11-19 14:45:03.831152
c919449c-3b7f-420c-abef-370555355468	f9608cbf-71be-4367-91cf-d92b6bbab4c2	READ	2025-11-19 14:45:03.831152
ccac5025-de65-46f4-a858-1d3f3b95b9a1	daf29ced-f928-4756-bfb6-34a0d24a4fc0	ADMIN	2025-11-19 14:45:03.831152
f45f7d5a-6393-43d9-acc7-f517d9d390f8	ac0e7b2f-bf1b-4ce0-8e37-2f3629c6f635	READ_WRITE	2025-11-19 14:45:03.831152
dacfb38a-e2c1-4df6-8a6a-6744940cc9f8	22df4765-a802-4445-9f4f-dd4d5b5def1d	READ_WRITE	2025-11-19 14:45:03.831152
d1521789-9cf5-4c31-b1fc-c55050b20098	e67b1492-c9ef-4e11-837d-ff275f6377f6	READ	2025-11-19 14:45:03.831152
86995f45-e9b6-4a67-8551-d3ebcd438f64	a02d09b4-ad32-4bc8-8174-02863f7b4a36	READ_WRITE	2025-11-19 14:45:03.831152
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, username, first_name, last_name, email, role, created_at) FROM stdin;
200980f1-3307-4d2f-947a-1ba8c6abb112	ivanov_alex	Александр	Иванов	a.ivanov@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
735a1b75-7f24-4c00-93e6-2ff0f2f60271	petrov_mihail	Михаил	Петров	m.petrov@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
bb4aa680-e597-40ab-ae83-c687e3fbf655	sidorova_ekat	Екатерина	Сидорова	e.sidorova@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
94c3af54-d9b0-4e65-a32e-a0a371557af0	volkova_svet	Светлана	Волкова	s.volkova@hospital.ru	NURSE	2025-11-19 14:41:12.640599
c919449c-3b7f-420c-abef-370555355468	orlova_olga	Ольга	Орлова	o.orlova@hospital.ru	NURSE	2025-11-19 14:41:12.640599
ccac5025-de65-46f4-a858-1d3f3b95b9a1	kozlov_vlad	Владимир	Козлов	v.kozlov@hospital.ru	ADMIN	2025-11-19 14:41:12.640599
f45f7d5a-6393-43d9-acc7-f517d9d390f8	romanov_andrey	Андрей	Романов	a.romanov@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
dacfb38a-e2c1-4df6-8a6a-6744940cc9f8	nikitina_tat	Татьяна	Никитина	t.nikitina@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
d1521789-9cf5-4c31-b1fc-c55050b20098	belova_irina	Ирина	Белова	i.belova@hospital.ru	NURSE	2025-11-19 14:41:12.640599
86995f45-e9b6-4a67-8551-d3ebcd438f64	frolov_viktor	Виктор	Фролов	v.frolov@hospital.ru	DOCTOR	2025-11-19 14:41:12.640599
\.


--
-- Name: examination_results examination_results_medical_document_id_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.examination_results
    ADD CONSTRAINT examination_results_medical_document_id_key UNIQUE (medical_document_id);


--
-- Name: examination_results examination_results_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.examination_results
    ADD CONSTRAINT examination_results_pkey PRIMARY KEY (id);


--
-- Name: medical_document_comments medical_document_comments_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_document_comments
    ADD CONSTRAINT medical_document_comments_pkey PRIMARY KEY (id);


--
-- Name: medical_documents medical_documents_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_documents
    ADD CONSTRAINT medical_documents_pkey PRIMARY KEY (id);


--
-- Name: medical_records medical_records_medical_document_id_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_records
    ADD CONSTRAINT medical_records_medical_document_id_key UNIQUE (medical_document_id);


--
-- Name: medical_records medical_records_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_records
    ADD CONSTRAINT medical_records_pkey PRIMARY KEY (id);


--
-- Name: patient_cards patient_cards_patient_id_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.patient_cards
    ADD CONSTRAINT patient_cards_patient_id_key UNIQUE (patient_id);


--
-- Name: patient_cards patient_cards_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.patient_cards
    ADD CONSTRAINT patient_cards_pkey PRIMARY KEY (id);


--
-- Name: patients patients_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.patients
    ADD CONSTRAINT patients_pkey PRIMARY KEY (id);


--
-- Name: user_patient_card_access user_patient_card_access_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_patient_card_access
    ADD CONSTRAINT user_patient_card_access_pkey PRIMARY KEY (user_id, patient_card_id);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- Name: users users_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_username_key UNIQUE (username);


--
-- Name: examination_results examination_results_medical_document_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.examination_results
    ADD CONSTRAINT examination_results_medical_document_id_fkey FOREIGN KEY (medical_document_id) REFERENCES public.medical_documents(id) ON DELETE CASCADE;


--
-- Name: medical_document_comments medical_document_comments_author_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_document_comments
    ADD CONSTRAINT medical_document_comments_author_id_fkey FOREIGN KEY (author_id) REFERENCES public.users(id) ON DELETE CASCADE;


--
-- Name: medical_document_comments medical_document_comments_medical_document_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_document_comments
    ADD CONSTRAINT medical_document_comments_medical_document_id_fkey FOREIGN KEY (medical_document_id) REFERENCES public.medical_documents(id) ON DELETE CASCADE;


--
-- Name: medical_documents medical_documents_author_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_documents
    ADD CONSTRAINT medical_documents_author_id_fkey FOREIGN KEY (author_id) REFERENCES public.users(id) ON DELETE CASCADE;


--
-- Name: medical_documents medical_documents_patient_card_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_documents
    ADD CONSTRAINT medical_documents_patient_card_id_fkey FOREIGN KEY (patient_card_id) REFERENCES public.patient_cards(id) ON DELETE CASCADE;


--
-- Name: medical_records medical_records_medical_document_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.medical_records
    ADD CONSTRAINT medical_records_medical_document_id_fkey FOREIGN KEY (medical_document_id) REFERENCES public.medical_documents(id) ON DELETE CASCADE;


--
-- Name: patient_cards patient_cards_patient_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.patient_cards
    ADD CONSTRAINT patient_cards_patient_id_fkey FOREIGN KEY (patient_id) REFERENCES public.patients(id) ON DELETE CASCADE;


--
-- Name: user_patient_card_access user_patient_card_access_patient_card_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_patient_card_access
    ADD CONSTRAINT user_patient_card_access_patient_card_id_fkey FOREIGN KEY (patient_card_id) REFERENCES public.patient_cards(id) ON DELETE CASCADE;


--
-- Name: user_patient_card_access user_patient_card_access_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.user_patient_card_access
    ADD CONSTRAINT user_patient_card_access_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(id) ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

\unrestrict 2cI99YIrarXOTfxjG3dOHaxtTAIz36AOQdNk7BOGCNiUzB1OiEY29fpAyn4hQw1

