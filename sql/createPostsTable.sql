CREATE TABLE Posts (
    Id SERIAL PRIMARY KEY,
    Content TEXT,
    Name TEXT
);

INSERT INTO
    Posts (Content, Name)
VALUES
    ('The cat will respond to jazz music', 'Gleg');

