CREATE TABLE Posts (
    Id SERIAL PRIMARY KEY,
    Post_id INT,
    Title TEXT,
    Content TEXT,
    FOREIGN KEY (Post_Id) REFERENCES Users (User_Id)
);

INSERT INTO
    Posts (Post_Id, Title, Content)
VALUES
    (1, 'Missing Cat', 'The cat will respond to jazz music');

