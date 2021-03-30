CREATE TABLE Chats (
    Id SERIAL PRIMARY KEY,
    User_info VARCHAR(40),
    Message TEXT
);

INSERT INTO 
    Chats (User_info, Message)

VALUES 
    ('Glegg', 'I am Glegg, very nice to meet, you.');