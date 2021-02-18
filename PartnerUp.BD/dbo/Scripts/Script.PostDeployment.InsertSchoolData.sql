INSERT INTO [School] (Name, Website)
VALUES ('Easy Swing', 'https://easy-swing.dance/'),
		('Apollo Swing', 'https://www.apolloswing.be/fr')

INSERT INTO [Address] (Name, Number, Street, City, Country, Department, LinkGoogle, PostalCode)
VALUES ('Espace Rodelle', '15-17', 'Rue du Danemark', 'Brussels', 'Belgium', null,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2519.9339321648663!2d4.332616515103958!3d50.83238766765251!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c3c46b84954b15%3A0x7d44558c4e3bfbc!2sRue%20de%20Danemark%2015%2C%201060%20Saint-Gilles!5e0!3m2!1ses!2sbe!4v1613476090281!5m2!1ses!2sbefalse', '1060'),
('Novanois', '3', 'Rue des Ailes', 'Brussels', 'Belgium', null, 'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2518.0373994383312!2d4.3747253151055085!3d50.86750736510773!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c3c36d2e80b9f1%3A0x79a9458ef8e8f6f2!2sNovanois%2C%20Locaux%20R%C3%A9p%C3%A9tition%20Danse%20Et%20Musique%2C%20Salle%20De%20F%C3%AAte!5e0!3m2!1ses!2sbe!4v1613477360660!5m2!1ses!2sbe', '1030'),
('Fred Academy', '18', 'Rue de la Révolution', 'Brussels', 'Belgium', null, null, '1000')

INSERT INTO [SchoolAddress] (IdSchool, IdAddress)
VALUES (1,1),
		(1,2),
		(1,3),
		(2,1)