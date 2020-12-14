
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (1, N'9A', N'!9 Street', N'Ohio', 43210, N'America', 1)
INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (2, N'10B', N'30 Street', N'Ohio', 42312, N'America', 2)
INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (3, N'10', N'21 Street', N'Ohio', 43213, N'America', 3)
INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (4, N'5', N'Street # 3', N'Lowa', 50010, N'Amerca', 5)
INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (5, N'7', N'S # 7', N'Lowa', 50010, N'America', 6)
INSERT [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (6, N'9L', N'14 Street', N'Lowa', 50010, N'America', 4)
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Email] ON 

INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (1, N'a@gmail.com', 1, 1)
INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (2, N'b@gamil.com', 1, 2)
INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (3, N'c@gamil.com', 1, 3)
INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (4, N'd@gmail.com', 1, 4)
INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (5, N'e@hotmail.com', 0, 5)
INSERT [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (6, N'f@yahoo.com', 1, 6)
SET IDENTITY_INSERT [dbo].[Email] OFF
GO
SET IDENTITY_INSERT [dbo].[Phone] ON 

INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (1, N'5647891', N'555-555-4567', 1, 1)
INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (2, N'2354789', N'555-555-4785', 1, 2)
INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (3, N'7854781', N'555-555-3256', 1, 3)
INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (4, N'783245', N'555-555-3278', 1, 4)
INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (5, N'784239', N'555-555-5685', 1, 5)
INSERT [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (6, N'159753', N'555-555-3768', 1, 6)
SET IDENTITY_INSERT [dbo].[Phone] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Name]) VALUES (1, N'Emily')
INSERT [dbo].[User] ([UserId], [Name]) VALUES (2, N'Lilly')
INSERT [dbo].[User] ([UserId], [Name]) VALUES (3, N'Richard')
INSERT [dbo].[User] ([UserId], [Name]) VALUES (4, N'carry')
INSERT [dbo].[User] ([UserId], [Name]) VALUES (5, N'Dannie')
INSERT [dbo].[User] ([UserId], [Name]) VALUES (6, N'Sara')
SET IDENTITY_INSERT [dbo].[User] OFF
