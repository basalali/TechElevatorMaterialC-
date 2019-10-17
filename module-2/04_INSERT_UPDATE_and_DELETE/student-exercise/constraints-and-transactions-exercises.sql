-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
SELECT * FROM actor 

INSERT actor (first_name, last_name)
VALUES ('Hampton', 'Avenue'), ('Lisa', 'Byway')
 



-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

SELECT * FROM film
where title = 'Euclidean PI'

INSERT film (title, description, release_year, length,language_id)
VALUES ('Euclidean PI', '"The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 198, 1)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.


SELECT * FROM film_actor fa
INSERT film_actor (actor_id, film_id)
VALUES (202, 1006)

INSERT film_actor (film_id, actor_id)
values (201, 1007);

-- 4. Add Mathmagical to the category table.

INSERT category (name)
VALUES ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
-- Karate Moon is 494, pi is 1006
INSERT film_category(film_id, category_id)
VALUES (494,17), (1006, 17), (274, 17), (714, 17), (996, 17)




-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE film
SET rating = 'G'
where film_id in
(select film_id from film_category where film_category.category_id = 17);


-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory (film_id, store_id) 
VALUES (1007, 1);
INSERT INTO inventory (film_id, store_id) 
VALUES (1006, 2);


-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)

DELETE FROM film
WHERE title = 'Euclidean PI'

-- No, it violates foreign key constraint on film_actor table, columbus film_id

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
delete from category
where name = 'Mathmagical';
--NO, it violates foreign key constraint on table film_category, in column category_ID

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)

DELETE FROM film_category 
WHERE category_id = 17
DELETE FROM category
where name = 'Mathmagical'

--Yes, it succeeded because both instances of the primary key (catergory_ID) were deleted at the same time and
-- had no other references on any other table, as PK or FK.

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
DELETE FROM category
where name = 'Mathmagical'

DELETE FROM film
WHERE title = 'Euclidean PI'

--Mathmagical deletion succeeded, however "Euclidean PI" did not succeed 
--The film_id is still referenced by film_actor table.


-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--The two film_actor insertions that we created earlier with "Euclidean PI" would have to be deleted and 
--also the inventory insertions for each store for that same movie. 
