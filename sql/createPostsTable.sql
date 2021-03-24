CREATE TABLE Posts (
    Post_Id SERIAL PRIMARY KEY, 
    Title TEXT,
    Content TEXT,
    FOREIGN KEY (Post_id) REFERENCES student (User_Id)
);

INSERT INTO
    Users (Title, Content)
VALUES
    ('Missing Cat', "The cat will respond to jazz music");

