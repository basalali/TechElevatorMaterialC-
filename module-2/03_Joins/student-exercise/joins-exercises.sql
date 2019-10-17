-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT f.title FROM actor a
JOIN film_actor AS fa ON a.actor_id = fa.actor_id
JOIN film AS f ON fa.film_id = f.film_id
WHERE a.first_name = 'Nick' AND a.last_name = 'Stallone'


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT f.title FROM actor AS a
JOIN film_actor AS fa ON a.actor_id = fa.actor_id
JOIN film AS f ON f.film_id = fa.film_id
WHERE a.first_name = 'Rita' AND a.last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT f.title FROM actor a
JOIN film_actor fa ON a.actor_id = fa.actor_id
JOIN film f ON fa.film_id = f.film_id
WHERE  a.first_name = 'Judy' AND a.last_name = 'Dean' OR a.first_name = 'River' AND a.last_name = 'Dean'

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT title FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Documentary'


-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT title FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT title FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Children' AND f.rating = 'G'


-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT title FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Family' AND f.rating = 'G' AND f.length < 120



-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT f.title FROM film f
JOIN film_actor fa ON fa.film_id = f.film_id
JOIN actor a ON a.actor_id = fa.actor_id
WHERE a.first_name = 'Matthew' AND a.last_name = 'Leigh' AND f.rating = 'G'



-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT title FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Sci-Fi' AND f.release_year = 2006


-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT title FROM film f
JOIN film_actor fa ON fa.film_id = f.film_id
JOIN actor a ON a.actor_id = fa.actor_id
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON c.category_id = fc.category_id
WHERE name = 'Action' AND a.first_name = 'Nick' AND a.last_name = 'Stallone'


-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT a.address, c.city, a.district, cr.country FROM Store s 
JOIN address a ON s.address_id = a.address_id
JOIN city c ON c.city_id = a.city_id
JOIN country cr ON c.country_id = cr.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT s.store_id, a.address, stf.first_name + ' ' + stf.last_name AS 'Manager_Name' FROM Store s
JOIN address a ON s.address_id = a.address_id
JOIN staff stf ON stf.store_id = s.store_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP 10 c.first_name + ' ' + c.last_name AS Customer_First_Last_Name, COUNT(r.rental_id) AS 'Number of Rentals' FROM rental r
JOIN customer c ON r.customer_id = c.customer_id
GROUP BY c.first_name + ' ' + c.last_name
ORDER BY  'Number of Rentals' DESC
 
-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10 c.first_name + ' ' + c.last_name AS Customer_First_Last_Name, SUM(p.amount) 'Dollars Spent' FROM payment p
JOIN customer c ON c.customer_id = p.customer_id
GROUP BY c.first_name + ' ' + c.last_name
ORDER BY  'Dollars Spent' DESC

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)


SELECT s.store_id, a.address, count(r.rental_id) 'Number of Rentals', sum(p.amount) 'Total Sales', SUM(p.amount)/COUNT(r.rental_id) 'average sale' FROM Store s
JOIN address a ON s.address_id = a.address_id
JOIN inventory i ON i.store_id = s.store_id
JOIN rental r ON r.inventory_id = i.inventory_id
JOIN payment p ON p.rental_id = r.rental_id
GROUP BY a.address, s.store_id



-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10 title, COUNT(r.rental_id) count FROM film f
JOIN inventory i ON i.film_id = f.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
GROUP BY f.title
ORDER BY count DESC



-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP 5 c.name, count(r.rental_id) count FROM film f
JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON fc.category_id = c.category_id
JOIN inventory i ON i.film_id = f.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
GROUP by c.name
ORDER by count DESC


-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT TOP 5 f.title, count(r.rental_id) count FROM film f
JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON fc.category_id = c.category_id
JOIN inventory i ON i.film_id = f.film_id
JOIN rental r ON r.inventory_id = i.inventory_id
WHERE c.name = 'Action'
GROUP by f.title
ORDER BY count DESC



-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP 10 a.first_name + ' ' + a.last_name 'Actor Name', count(r.rental_id) count FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON f.film_id = i.film_id
JOIN film_actor fa ON fa.film_id = f.film_id
JOIN actor a ON a.actor_id = fa.actor_id
GROUP BY a.first_name + ' ' + a.last_name
ORDER BY count DESC


-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP 5 a.first_name + ' ' + a.last_name 'Actor Name', count(r.rental_id) count FROM rental r
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON f.film_id = i.film_id
JOIN film_actor fa ON fa.film_id = f.film_id
JOIN actor a ON a.actor_id = fa.actor_id
JOIN film_category fc ON fc.film_id = f.film_id
JOIN category c ON fc.category_id = c.category_id
WHERE c.name = 'Comedy'
GROUP BY a.first_name + ' ' + a.last_name
ORDER BY count DESC
