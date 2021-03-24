CREATE TABLE Posts (
    Post_Id SERIAL PRIMARY KEY, 
    Title TEXT,
    Content TEXT,
    FOREIGN KEY (Post_id) REFERENCES Users (User_Id)
);

INSERT INTO
    Posts (Title, Content)
VALUES
    ('Missing Cat', 'The cat will respond to jazz music');

