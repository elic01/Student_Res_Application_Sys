CREATE TABLE [dbo].[students] (
    [student_id]            VARCHAR (9)   NOT NULL,
    [student_name]          VARCHAR (255) NOT NULL,
    [student_surname]       VARCHAR (255) NOT NULL,
    [student_email]         VARCHAR (255) NOT NULL,
    [national_id_number]    VARCHAR (13)  NOT NULL,
    [level_part]            VARCHAR (255) NOT NULL,
    [date_of_birth]         DATE          NOT NULL,
    [phone_number]          VARCHAR (255) NOT NULL,
    [address]               VARCHAR (255) NOT NULL,
    [special_circumstances] VARCHAR (255) NULL,
    [allergies]             VARCHAR (255) NULL,
    [guardian_name]         VARCHAR (255) NULL,
    [guardian_id]           VARCHAR (13)  NULL,
    [guardian_phone_number] VARCHAR (255) NULL,
    [relation]              VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([student_id] ASC),
    CONSTRAINT [student_id_format] CHECK ([student_id] like 'H230[0-9][0-9][0-9][A-Z]')
);

