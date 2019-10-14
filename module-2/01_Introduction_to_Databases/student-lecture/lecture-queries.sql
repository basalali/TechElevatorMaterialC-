-- SELECT ... FROM
-- Selecting the names for all countries
SELECT * FROM country 

-- Selecting the name and population of all countries

SELECT name, population FROM country 

-- Selecting all columns from the city table
SELECT  * FROM city 

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT * FROM city
WHERE district LIKE 'Oh__';

-- Selecting countries that gained independence in the year 1776
SELECT * FROM Country
WHERE indepyear = 1776

-- Selecting countries not in Asia
SELECT * From Country
WHERE continent != 'Asia'



-- Selecting countries that do not have an independence year

SELECT * FROM Country
WHERE indepyear IS Null 


-- Selecting countries that do have an independence year
SELECT * FROM Country
WHERE indepyear IS Not Null 


-- Selecting countries that have a population greater than 5 million
SELECT * From Country
Where population > 5000000


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT * FROM City
WHERE district = 'Ohio' AND population > 400000

-- Selecting country names on the continent North America or South America

SELECT name  FROM Country
WHERE continent = 'North America' OR continent = 'South America'


-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword

SELECT 

