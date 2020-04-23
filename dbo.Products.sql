CREATE TABLE [dbo].[Products] (
    [ProductId]   INT             IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX)  NOT NULL,
    [Name]        NVARCHAR (MAX)  NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [CategoryId]  NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [CategoryId1] INT             NULL,
    [Image]       NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Products_Categories_CategoryId1] FOREIGN KEY ([CategoryId1]) REFERENCES [dbo].[Categories] ([CategoryId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId1]
    ON [dbo].[Products]([CategoryId1] ASC);

GO
BEGIN
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([CategoryId], [Name]) VALUES (1, N'Costumes')
INSERT INTO [dbo].[Categories] ([CategoryId], [Name]) VALUES (2, N'Collectibles')
INSERT INTO [dbo].[Categories] ([CategoryId], [Name]) VALUES (3, N'Toys')
SET IDENTITY_INSERT [dbo].[Categories] OFF
END
GO