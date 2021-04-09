CREATE TABLE Posts (
    Id SERIAL PRIMARY KEY,
    Content TEXT,
    Name TEXT,
    PostImage VARCHAR
);

INSERT INTO
    Posts (Content, Name)
VALUES
    ('The cat will respond to jazz music', 'Gleg');

