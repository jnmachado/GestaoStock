CREATE TABLE [dbo].[tbl_login] (
    [username]   VARCHAR (20) NOT NULL,
    [passwd]     VARCHAR (20) NULL,
    [privlg]     INT          NOT NULL,
    [last_login] DATETIME     NULL,
    [nome]       VARCHAR (50) NULL,
    [email]      VARCHAR (50) NULL,
    [tel]        INT          NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);

CREATE TABLE [dbo].[tbl_mov] (
    [datahora] DATETIME     NOT NULL,
    [username] VARCHAR (20) NOT NULL,
    [produto]  VARCHAR (50) NULL,
    [qtd]      INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([username] ASC, [datahora] ASC),
    FOREIGN KEY ([username]) REFERENCES [dbo].[tbl_login] ([username])
);

CREATE TABLE [dbo].[tbl_stock] (
    [ref]       VARCHAR (50) NOT NULL,
    [qtd]       INT          NOT NULL,
    [qtd_min]   INT          NOT NULL,
    [custo_uni] FLOAT (53)   NULL,
    [pvp_uni]   FLOAT (53)   NULL,
    [nome]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ref] ASC)
);

