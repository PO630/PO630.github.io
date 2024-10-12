-- Section : Manager

-- Table Entreprise
CREATE TABLE Entreprise (
    id SERIAL PRIMARY KEY,                      -- Identifiant unique pour chaque entreprise
    nom VARCHAR(100) NOT NULL,                  -- Nom de l'entreprise
    typeEntreprise VARCHAR(50) NOT NULL,        -- Type de l'entreprise (ex : 'Menuiserie', 'Plomberie', etc.)
    siret VARCHAR(14) NOT NULL UNIQUE           -- SIRET de l'entreprise (format 14 caractères)
);

-- Table Manager
CREATE TABLE Manager (
    id SERIAL PRIMARY KEY AUTO_INCREMENT,               -- Identifiant unique pour chaque manager
    nom VARCHAR(50) NOT NULL,                           -- Nom du manager
    prenom VARCHAR(50) NOT NULL,                        -- Prénom du manager
    mail VARCHAR(100) NOT NULL UNIQUE,                  -- Mail unique du manager
    titre VARCHAR(50),                                  -- Titre du manager (exemple : CEO)
    id_entreprise INT NOT NULL,                         -- Identifiant de l'entreprise associée
    FOREIGN KEY (id_entreprise) REFERENCES Entreprise(id)  -- Clé étrangère vers la table Entreprise
);

-- Section : Artisan

-- Table Artisan
CREATE TABLE Artisan (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    mail VARCHAR(100) NOT NULL UNIQUE,
    manager_id INT NOT NULL,
    FOREIGN KEY (manager_id) REFERENCES Manager(id)
);

-- Table Qualification
CREATE TABLE Qualification (
    id SERIAL PRIMARY KEY,              -- Identifiant unique pour chaque qualification
    nom VARCHAR(100) NOT NULL           -- Nom de la qualification
);

-- Table Qualifier
CREATE TABLE Qualifier (
    id SERIAL PRIMARY KEY,                                          -- Identifiant unique pour chaque association
    id_artisan INT NOT NULL,                                        -- Identifiant de l'artisan
    id_qualification INT NOT NULL,                                  -- Identifiant de la qualification
    FOREIGN KEY (id_artisan) REFERENCES Artisan(id),                -- Clé étrangère vers la table Artisan
    FOREIGN KEY (id_qualification) REFERENCES Qualification(id)     -- Clé étrangère vers la table Qualification
);

-- Section : Artisan

-- Table Ouvrier
CREATE TABLE Ouvrier (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nom VARCHAR(50) NOT NULL,
    prenom VARCHAR(50) NOT NULL,
    mail VARCHAR(100) NOT NULL UNIQUE,
    manager_id INT ,
    FOREIGN KEY (manager_id) REFERENCES Manager(id)
);

-- Table Outil
CREATE TABLE Outil (
    id SERIAL PRIMARY KEY,            -- Identifiant unique pour chaque outil
    id_ouvrier INT NOT NULL,          -- Identifiant de l'ouvrier associé
    nom VARCHAR(100) NOT NULL,        -- Nom de l'outil
    type VARCHAR(50) NOT NULL,        -- Type de l'outil (ex : 'outil', 'véhicule', etc.)
    prix DECIMAL(10, 2) NOT NULL,     -- Prix de l'outil
    FOREIGN KEY (id_ouvrier) REFERENCES Ouvrier(id) -- Clé étrangère vers la table Ouvrier
);


-- Section : BDD

-- 1. Insérer des entreprises
INSERT INTO Entreprise (nom, typeEntreprise, siret) VALUES
('Menuiserie Dupont', 'Menuiserie', '12345678901234'),
('Plomberie Martin', 'Plomberie', '23456789012345'),
('Électricité Leroy', 'Électricité', '34567890123456'),
('Peinture Robert', 'Peinture', '45678901234567');

-- 2. Ajouter des managers
INSERT INTO Manager (nom, prenom, mail, titre, id_entreprise) VALUES
('Jean', 'Dupont', 'jean.dupont@example.com', 'CEO', 1),
('Albert', 'Martin', 'albert.martin@example.com', 'Directeur Technique', 1),
('Marie', 'Martin', 'marie.martin@example.com', 'Directrice', 2),
('Chloé', 'Bernard', 'chloe.bernard@example.com', 'Directrice Adjointe', 2), 
('Luc', 'Leroy', 'luc.leroy@example.com', 'Chef de Projet', 3),
('Émile', 'Fabre', 'emile.fabre@example.com', 'Directeur Technique', 3),  
('Sophie', 'Robert', 'sophie.robert@example.com', 'Directrice Technique', 4);
('Léon', 'David', 'leon.david@example.com', 'Directeur', 4); 

-- 3. Ajouter des artisans
INSERT INTO Artisan (nom, prenom, mail, manager_id) VALUES
('François', 'Lefebvre', 'francois.lefebvre@example.com', 1),
('Juliette', 'Dubois', 'juliette.dubois@example.com', 1),
('Pierre', 'Chevalier', 'pierre.chevalier@example.com', 2),
('Luc', 'Garnier', 'luc.garnier@example.com', 2),  
('Cécile', 'Dumas', 'cecile.dumas@example.com', 3),
('Thierry', 'Roussel', 'thierry.roussel@example.com', 3), 
('Sophie', 'Lambert', 'sophie.lambert@example.com', 4),
('Nicolas', 'Benoit', 'nicolas.benoit@example.com', 4),  
('Anne', 'Fabre', 'anne.fabre@example.com', 5),
('David', 'Maréchal', 'david.marechal@example.com', 5),  
('Léa', 'Pichon', 'lea.pichon@example.com', 6),
('Julien', 'Meyer', 'julien.meyer@example.com', 6);  

-- 4. Ajouter des qualifications pour les artisans
INSERT INTO Qualification (nom) VALUES
('Menuisier Certifié'),
('Plombier Certifié'),
('Électricien Certifié'),
('Peintre Certifié'),
('Jardinier Certifié'),
('Maçon Certifié');

-- Lier des qualifications aux artisans
INSERT INTO Qualifier (id_artisan, id_qualification) VALUES
(1, 1),  -- François est Menuisier Certifié
(1, 4),  -- François est aussi Peintre Certifié
(2, 2),  -- Juliette est Plombier Certifié
(3, 3),  -- Pierre est Électricien Certifié
(3, 5),  -- Pierre est aussi Jardinier Certifié
(4, 1),  -- Luc est Menuisier Certifié
(5, 2),  -- Cécile est Plombier Certifié
(6, 3),  -- Thierry est Électricien Certifié
(7, 4),  -- Sophie est Peintre Certifié
(8, 5),  -- Nicolas est Jardinier Certifié
(9, 1),  -- Anne est Menuisier Certifié
(10, 2), -- David est Plombier Certifié
(11, 3), -- Léa est Électricien Certifié
(12, 6); -- Julien est Maçon Certifié


-- 5. Ajouter des ouvriers
INSERT INTO Ouvrier (nom, prenom, mail, manager_id) VALUES
('Philippe', 'Simon', 'philippe.simon@example.com', 1),
('Carole', 'Morel', 'carole.morel@example.com', 1),
('Marc', 'Faucher', 'marc.faucher@example.com', 2),
('Léa', 'Boucher', 'lea.boucher@example.com', 2),  
('Charles', 'Guillaume', 'charles.guillaume@example.com', 3),
('Véronique', 'Colin', 'veronique.colin@example.com', 3),  
('Jean', 'Ménard', 'jean.menard@example.com', 4),
('François', 'Dupuy', 'francois.dupuy@example.com', 4),  
('Christophe', 'Leroy', 'christophe.leroy@example.com', 5),
('Marie', 'Giraud', 'marie.giraud@example.com', 5),  
('Vincent', 'Renaud', 'vincent.renaud@example.com', 6),
('Alice', 'Noir', 'alice.noir@example.com', 6); 


-- 6. Ajouter des outils pour les ouvriers
INSERT INTO Outil (id_ouvrier, nom, type, prix) VALUES
(1, 'Marteau', 'outil', 15.99),
(1, 'Camion', 'véhicule', 25000.00),
(2, 'Perceuse', 'outil', 49.99),
(2, 'Fourgon', 'véhicule', 22000.00),
(3, 'Scie', 'outil', 35.50),
(3, 'Véhicule', 'véhicule', 28000.00),
(4, 'Pelle', 'outil', 18.75),
(5, 'Tronçonneuse', 'outil', 120.00),
(5, 'Camionnette', 'véhicule', 30000.00),
(6, 'Tournevis', 'outil', 9.99),
(7, 'Marteau-piqueur', 'outil', 150.00),
(8, 'Rétroexcavateur', 'véhicule', 40000.00),
(9, 'Ciseau', 'outil', 12.50),
(10, 'Chariot élévateur', 'véhicule', 45000.00),
(11, 'Clé à molette', 'outil', 20.00),
(12, 'Fraiseuse', 'outil', 500.00);

