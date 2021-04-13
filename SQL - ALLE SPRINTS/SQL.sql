# SECTIE 1
    # Query 1
SELECT *
FROM countries;

    # Query 2
SELECT first_name, last_name
FROM employees;

    # Query 3
SELECT job_title, max_salary, min_salary, max_salary - min_salary AS verschil
FROM jobs;

    # Query 4
SELECT country_name
FROM countries
LIMIT 1;

    # Query 5
SELECT country_name
FROM countries
LIMIT 1 OFFSET 2;

    # Query 6
SELECT last_name AS achternaam, salary * 12 AS jaarsalaris
FROM employees
LIMIT 5;

    # Query 7
SELECT last_name AS achternaam, salary AS huidig_salaris, 300 AS opslag, salary
+ 300 AS nieuw_salaris
FROM employees;

    # Query 8
SELECT last_name AS achternaam, salary AS maandsalaris, 0.05 * salary AS
opslag, 1.05 * salary AS nieuw_salaris
FROM employees;

    # Query 9
SELECT last_name AS achternaam, salary AS maandsalaris, salary / 30 AS per_dag
FROM employees
LIMIT 1;

    # Query 10
SELECT last_name AS achternaam, salary AS maandsalaris, commission_pct AS
commissie_percentage, commission_pct * salary AS commissie, salary +
(commission_pct *salary) AS salaris_plus_commissie
FROM employees
LIMIT 3 OFFSET 12;



# SECTIE 2
    # Query 1
DESC jobs;

    # Query 2
SELECT CONCAT(first_name,' ',last_name) AS "Volledige Naam",
CONCAT(email,'@COMPANY.COM') AS "E-mailadres"
FROM employees;

    # Query 3
SELECT DISTINCT commission_pct
FROM employees;

    # Query 4
SELECT CONCAT(first_name, ' ',last_name, ' verdient ', salary*12, ' dollar per jaar.')
AS 'Jaarsalarissen'
FROM employees
LIMIT 3;

    # Query 5
SELECT last_name AS achternaam, CONCAT('$ ', salary) AS maandsalaris
FROM employees
LIMIT 5;

    # Query 6
SELECT DISTINCT department_id
FROM employees;

    # Query 7
SELECT first_name, last_name, hire_date
FROM employees
WHERE hire_date LIKE '%06-07';

    # Query 8
SELECT last_name, phone_number
FROM employees
WHERE phone_number LIKE '011.44%';

    # Query 9
SELECT department_name, manager_id
FROM departments
WHERE manager_id IS NULL;

    # Query 10
SELECT first_name, last_name, job_id
FROM employees
WHERE job_id LIKE 'AD%';


# SECTIE 3
    # Query 1
SELECT CONCAT(first_name,' ',last_name) AS naam, job_id AS soort_werk, salary
AS salaris
FROM employees
WHERE job_id='ST_CLERK' AND salary > 3000
ORDER BY salaris;

    # Query 2
SELECT city AS stad, country_id AS land
FROM locations
WHERE country_id = 'CA' OR country_id = 'UK';

    # Query 3
SELECT job_title AS functie, min_salary AS min_salaris, max_salary AS max_salaris, max_salary - min_salary AS verschil
FROM jobs
WHERE max_salary - min_salary > 6000 AND job_title<>'President'
ORDER BY verschil DESC;

    # Query 4
SELECT employee_id nummer, last_name AS achternaam, CONCAT('$ ',salary) AS
salaris
FROM employees
WHERE department_id IS NOT NULL AND department_id NOT IN(10, 20, 50) AND
salary < 10000
ORDER BY salary DESC;

    # Query 5
SELECT DISTINCT manager_id
FROM employees
WHERE manager_id not IN(100, 102, 103, 201, 205);

    # Query 6
SELECT last_name
FROM employees
WHERE last_name > 'F%'
ORDER BY last_name
LIMIT 5;

    # Query 7
SELECT first_name, last_name, salary
FROM employees
WHERE salary BETWEEN 12000 AND 20000 OR first_name LIKE 'E%'
ORDER BY salary, first_name;

    # Query 8
SELECT last_name AS achternaam, salary AS salaris, bonus,
CONCAT(salary+bonus, ' dollar') AS totaal
FROM employees
WHERE bonus IS NOT NULL
ORDER BY salary+bonus DESC;

    # Query 9
SELECT CONCAT(first_name,' ',last_name) AS
naam,CONCAT(email,'@COMPANY.COM') AS mailadres, phone_number AS
telefoon
FROM employees
WHERE phone_number NOT LIKE '%5%';

    # Query 10
SELECT first_name, last_name, hire_date
FROM employees
WHERE hire_date LIKE '%17'
ORDER BY last_name;



# SECTIE 4
    # Query 1
SELECT CONCAT(first_name,' ',last_name) AS naam,
CONCAT(LOWER(SUBSTR(first_name,1,1)),'.',LOWER(REPLACE(last_name,'
','')),'@company.com') AS 'e-mail'
FROM employees
ORDER BY last_name;

    # Query 2
SELECT job_title AS old_job_title, REPLACE(job_title,'Manager','Director') AS
new_job_title
FROM jobs
WHERE job_title LIKE '%Manager%';

    # Query 3
SELECT CONCAT(first_name,' ',last_name) AS naam,
LOWER(CONCAT(SUBSTR(first_name,1,1),SUBSTR(last_name,1,1))) AS
inlognaam
FROM employees
ORDER BY last_name;

    # Query 4
SELECT last_name AS achternaam, ROUND(salary) AS maandsalaris,
ROUND(salary / (36*4),2) AS per_uur, CEILING(salary/(36*4)) AS naar_boven,
FLOOR(salary/(36*4)) AS naar_beneden
FROM employees
ORDER BY last_name;

    # Query 5
SET lc_time_names = 'nl_NL';
SELECT employee_id, job_id, DATE_FORMAT(start_date, '%e %M %Y') AS
startdatum, DATE_FORMAT(end_date, '%e %M %Y') AS einddatum,
TIMESTAMPDIFF(YEAR, start_date, end_date) AS aantal_jaren,
TIMESTAMPDIFF(MONTH, start_date, end_date) AS aantal_maanden
FROM job_history
ORDER BY employee_id;

    # Query 6
SELECT CONCAT(first_name,' ',last_name) AS naam, DATE_FORMAT(hire_date,
'%d-%m-%Y') AS in_dienst, DATE_FORMAT(DATE_ADD(hire_date, INTERVAL 35
YEAR), '%d-%m-%Y') AS 35_jarig_jubileum
FROM employees
WHERE last_name<>'King'
ORDER BY hire_date
LIMIT 5;

    # Query 7
SELECT ROUND(MAX(highest_sal - lowest_sal)) AS grootste_verschil,
ROUND(MIN(highest_sal - lowest_sal)) AS kleinste_verschil,
ROUND(AVG(highest_sal - lowest_sal)) AS gemiddelde_verschil
FROM job_grades;

    # Query 8
SELECT COUNT(*) AS aantal_personeelsleden, COUNT(manager_id) AS
aantal_met_manager, count(commission_pct) AS aantal_met_commission_pct
FROM employees;

    # Query 9
SELECT ROUND(AVG(bonus)) AS gemiddelde_bonus_zonder_abel
FROM employees
where LAST_NAME <> 'Abel';

    # Query 10
SELECT CONCAT(first_name,' ',last_name) AS naam, job_id AS afdeling,
CONCAT('$ ', salary, ',=') AS salaris, CONCAT('$ ', FLOOR(0.0125*salary), ',=') AS
opslag, CONCAT('$ ', FLOOR(salary+(0.0125*salary)), ',=') AS nieuw_salaris
FROM employees
WHERE job_id LIKE 'SA%'
ORDER BY last_name



# SECTIE 5
    # Query 1
SELECT department_name AS afdeling, COALESCE(manager_id, 'afdeling zonder
manager') AS manager
FROM departments
ORDER BY department_name;

    # Query 2
SET lc_time_names = 'nl_NL';
SELECT CONCAT('Vandaag is het ',DATE_FORMAT(SYSDATE(), '%d %M %Y'), '.')
AS vandaag;

    # Query 3
SELECT last_name, hire_date, CAST(hire_date AS CHAR(7)) AS 'jaar en maand'
FROM employees;

    # Query 4
SET lc_time_names = 'nl_NL';
SELECT CONCAT(first_name, ' ', last_name, ' kwam ', DATE_FORMAT(hire_date,
'%e %M %Y'), ' in dienst.') AS
overzicht_van_werknemers_met_datum_waarop_ze_in_dienst_zijn_gekomen
FROM employees
ORDER BY last_name;

    # Query 5
SELECT
last_name AS achternaam
, job_id AS functie
, CONCAT('$ ', salary, ',=') AS salaris
, COALESCE(CONCAT(ROUND(commission_pct * 100),' %'), '') AS
commissie_percentage
, COALESCE(CONCAT('$ ',ROUND(commission_pct * salary),',='), '') AS commissie, COALESCE(CONCAT('$ ', bonus, ',='),'') AS bonus
, CONCAT('$ ',salary+COALESCE(bonus,0)+
(COALESCE(commission_pct,0)*salary),',=') totaal_salaris
FROM employees
ORDER BY last_name;

    # Query 6
SELECT last_name achternaam, COALESCE(commission_pct, '-----') commissie,
CASE commission_pct
WHEN 0.2 THEN 'gemiddeld'
WHEN 0.3 THEN 'hoog'
WHEN 0.15 THEN 'laag'
ELSE 'geen'
END AS extra_betaling
FROM employees;

    # Query 7
SELECT department_name AS afdeling,
CASE location_id
WHEN 1800 THEN 'Canada'
WHEN 25000 THEN 'Verenigd Koninkrijk'
ELSE 'Verenigde Staten'
END AS land
FROM departments
ORDER BY department_name;

    # Query 8
SELECT last_name AS achternaam, salary AS salaris,
CASE
WHEN salary > 20000 THEN 'Meer dan 20.000: Je bent de grootste baas!'
WHEN salary > 15000 THEN 'Meer dan 15000: Is heel goed!'
WHEN salary > 10000 THEN 'Meer dan 10000: Is goed!'
WHEN salary > 5000 THEN 'Meer dan 5000: Gaat wel!'
ELSE 'Minder dan 5000: Salaris is laag!'
END AS categorie
FROM employees
ORDER BY salary DESC, last_name;

    # Query 9
SELECT last_name AS achternaam, salary*12 AS per_jaar, salary AS per_maand,
ROUND(salary*12/365.25) AS per_dag, salary*12/365.25 AS per_dag_onafgerond
FROM employees
ORDER BY last_name;

    # Query 10
SET lc_time_names = 'nl_NL';
SELECT CONCAT(DATE_FORMAT(SYSDATE(),'%k:%i'), ' uur op ',
DAYNAME(SYSDATE()),' ',DATE_FORMAT(SYSDATE(),'%d %M %Y'), ' week ',
DATE_FORMAT(SYSDATE(),'%u')) AS "Het is nu ...";



# SECTIE 6
    # Query 1
a) Met een NATURAL JOIN
SELECT location_id, state_province, country_name
FROM locations NATURAL JOIN countries;
b) Met een JOIN USING
SELECT location_id, state_province, country_name
FROM locations JOIN countries USING(country_id);
c) Met een JOIN ON
SELECT location_id, state_province, country_name
FROM locations JOIN countries ON locations.country_id = countries.country_id;
d) Met een EQUI JOIN
SELECT location_id, state_province, country_name
FROM locations, countries
WHERE locations.country_id = countries.country_id;

    # Query 2
SELECT d.department_name, CONCAT(e.first_name, ' ', e.last_name) AS employee
FROM departments d
LEFT JOIN employees e ON e.employee_id = d.manager_id;

    # Query 3
SELECT e.last_name, h.job_id, h.start_date, h.end_date
FROM employees e
JOIN job_history h ON e.employee_id = h.employee_id;

    # Query 4
SELECT h.employee_id, e.last_name, h.start_date, h.end_date, h.job_id
FROM job_history h
LEFT JOIN employees e ON e.employee_id = h.employee_id
ORDER BY last_name;

    # Query 5
SELECT e.last_name, j.job_title
FROM employees e
LEFT JOIN jobs j ON e.job_id = j.job_id
LEFT JOIN departments d ON e.department_id = d.department_id
WHERE d.department_name = 'Shipping'
ORDER BY j.job_title DESC, last_name;

    # Query 6
SELECT country_id, country_name, region_id, region_name
FROM countries JOIN regions USING(region_id);

    # Query 7
SELECT last_name, department_name, job_title
FROM employees e
LEFT JOIN departments d ON e.department_id = d.department_id
JOIN jobs j ON e.job_id = j.job_id
ORDER BY last_name;

    # Query 8
SELECT d.department_name AS afdeling, COALESCE(CONCAT(first_name, ' ',
last_name), '') AS manager
FROM employees e RIGHT JOIN departments d ON d.manager_id = e.employee_id
ORDER BY afdeling;

    # Query 9
SELECT CONCAT(first_name, ' ' , last_name) naam, job_title, CONCAT('$ ',
max_salary) AS max_salary, CONCAT('$ ', min_salary) AS min_salary, CONCAT('$' ,
max_salary - min_salary) AS verschil
FROM employees e
JOIN jobs j ON e.job_id = j.job_id
ORDER BY max_salary - min_salary DESC, last_name;

    # Query 10
SELECT last_name AS achternaam, COALESCE(department_name,'') AS afdeling,
COALESCE(city,'') AS stad, COALESCE(country_name,'') AS land,
COALESCE(region_name,'') AS regio
FROM employees
LEFT JOIN departments ON employees.department_id =
departments.department_id
LEFT JOIN locations ON departments.location_id = locations.location_id
LEFT JOIN countries ON countries.country_id = locations.country_id
LEFT JOIN regions ON regions.region_id = countries.region_id
ORDER BY region_name, country_name, city, last_name;