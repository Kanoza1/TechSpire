-- Add topics
INSERT INTO Topics (Name) VALUES 
('Syntax'),
('OOP'), 
('Data Structure'),
('ML'),
('Data Analysis'),
('Data Science');

-- Update questions to assign topics based on keywords in question text
UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'Syntax')
WHERE Text LIKE '%variable%' OR Text LIKE '%syntax%' OR Text LIKE '%print%' OR Text LIKE '%string%';

UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'OOP')
WHERE Text LIKE '%class%' OR Text LIKE '%object%' OR Text LIKE '%method%' OR Text LIKE '%inheritance%';

UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'Data Structure')
WHERE Text LIKE '%list%' OR Text LIKE '%array%' OR Text LIKE '%dictionary%' OR Text LIKE '%tuple%';

UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'ML')
WHERE Text LIKE '%machine learning%' OR Text LIKE '%ml%' OR Text LIKE '%model%' OR Text LIKE '%algorithm%';

UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'Data Analysis')
WHERE Text LIKE '%analysis%' OR Text LIKE '%statistics%' OR Text LIKE '%chart%' OR Text LIKE '%pandas%';

UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'Data Science')
WHERE Text LIKE '%data science%' OR Text LIKE '%pipeline%' OR Text LIKE '%preprocessing%';

-- Set default topic for remaining questions
UPDATE Questions 
SET TopicId = (SELECT Id FROM Topics WHERE Name = 'Syntax')
WHERE TopicId IS NULL; 