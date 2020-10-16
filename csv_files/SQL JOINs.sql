SELECT name, plural_name_short, second_name 
FROM elements
INNER JOIN events 
ON events.most_captained = elements.id
INNER JOIN element_types
ON elements.element_type = element_types.id
WHERE first_name = 'Kevin'