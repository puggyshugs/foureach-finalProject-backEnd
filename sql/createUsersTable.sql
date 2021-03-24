CREATE TABLE Users (
    User_Id SERIAL PRIMARY KEY,
    Name TEXT,
    Age INTEGER,
    About TEXT
);

INSERT INTO
    Users (Name, Age, About)
VALUES
    ('John Smith', 32, 'I like jazz music');

