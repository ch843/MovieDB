create table Movies
(
    Id       INTEGER
        primary key autoincrement,
    Category TEXT    not null,
    Title    TEXT    not null,
    Year     INTEGER not null,
    Director TEXT,
    Rating   TEXT,
    Edited   INTEGER not null,
    Lent     TEXT,
    Notes    TEXT
);

