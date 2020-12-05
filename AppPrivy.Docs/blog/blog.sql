CREATE SCHEMA Blog;
GO

DROP TABLE Blog.PostTag
DROP TABLE Blog.PostCategory
DROP TABLE Blog.PostComment
DROP TABLE Blog.PostMeta

DROP TABLE Blog.Tag
DROP TABLE Blog.Category
DROP TABLE Blog.Post
DROP TABLE Blog.Author
GO

CREATE TABLE Blog.Author (
  AuthorId BIGINT NOT NULL IDENTITY,
  FirstName VARCHAR(50) NULL DEFAULT NULL,
  MiddleName VARCHAR(50) NULL DEFAULT NULL,
  LastName VARCHAR(50) NULL DEFAULT NULL,
  Mobile VARCHAR(15) NULL,
  Email VARCHAR(50) NULL,
  PasswordHash VARCHAR(32) NOT NULL,
  RegisteredAt DATETIME2(0) NOT NULL,
  LastLogin DATETIME2(0) NULL DEFAULT NULL,
  Intro VARCHAR(255) NULL DEFAULT NULL,
  Profile VARCHAR(Max) NULL DEFAULT NULL,
  PRIMARY KEY (AuthorId),
  CONSTRAINT uq_mobile UNIQUE  (mobile ASC),
  CONSTRAINT uq_email UNIQUE  (email ASC) );
  

  
  CREATE TABLE Blog.Post (
  PostId BIGINT NOT NULL IDENTITY,
  AuthorId BIGINT NOT NULL,
  ParentId BIGINT NULL DEFAULT NULL,
  Title VARCHAR(75) NOT NULL,
  MetaTitle VARCHAR(100) NULL,
  Slug VARCHAR(100) NOT NULL,
  Summary VARCHAR(255) NULL,
  Published SMALLINT NOT NULL DEFAULT 0,
  CreatedAt DATETIME2(0) NOT NULL,
  UpdatedAt DATETIME2(0) NULL DEFAULT NULL,
  PublishedAt DATETIME2(0) NULL DEFAULT NULL,
  Content VARCHAR(Max) NULL DEFAULT NULL,
  PRIMARY KEY (PostId),
  CONSTRAINT uq_slug UNIQUE  (Slug ASC)
 ,
  CONSTRAINT fk_post_user
    FOREIGN KEY (AuthorId)
    REFERENCES Blog.Author (AuthorId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

DROP INDEX   idx_post_user ON Blog.Post
CREATE INDEX idx_post_user ON Blog.Post (AuthorId ASC);

DROP INDEX   idx_post_parent ON Blog.Post
CREATE INDEX idx_post_parent ON Blog.Post (ParentId ASC);


ALTER TABLE Blog.Post 
ADD CONSTRAINT fk_post_parent
  FOREIGN KEY (ParentId)
  REFERENCES Blog.Post (PostId)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;  
  
  
  

  
  CREATE TABLE Blog.PostMeta (
  PostMetaId BIGINT NOT NULL IDENTITY,
  PostId BIGINT NOT NULL,
  Nkey VARCHAR(50) NOT NULL,
  Content VARCHAR(500) NULL DEFAULT NULL,
  PRIMARY KEY (PostMetaId)
 ,
  CONSTRAINT uq_post_meta UNIQUE (PostId ASC),
  CONSTRAINT fk_meta_post
    FOREIGN KEY (PostId)
    REFERENCES Blog.Post (PostId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

DROP INDEX   idx_meta_post ON Blog.PostMeta
CREATE INDEX idx_meta_post ON Blog.PostMeta (PostId ASC);




CREATE TABLE Blog.PostComment (
  PostCommentId BIGINT NOT NULL IDENTITY,
  PostId BIGINT NOT NULL,
  ParentId BIGINT NULL DEFAULT NULL,
  Title VARCHAR(100) NOT NULL,
  Published SMALLINT NOT NULL DEFAULT 0,
  CreatedAt DATETIME2(0) NOT NULL,
  PublishedAt DATETIME2(0) NULL DEFAULT NULL,
  Content VARCHAR(Max) NULL DEFAULT NULL,
  PRIMARY KEY (PostCommentId) ,
  CONSTRAINT fk_comment_post
    FOREIGN KEY (PostId)
    REFERENCES Blog.Post (PostId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

DROP INDEX idx_comment_post ON Blog.PostComment
CREATE INDEX idx_comment_post ON Blog.PostComment (PostId ASC);

DROP INDEX   idx_comment_parent ON Blog.PostComment
CREATE INDEX idx_comment_parent ON Blog.PostComment (ParentId ASC);

ALTER TABLE Blog.PostComment 
ADD CONSTRAINT fk_comment_parent
  FOREIGN KEY (ParentId)
  REFERENCES Blog.PostComment (ParentId)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

GO
  

  

  CREATE TABLE Blog.Category (
  CategoryId BIGINT NOT NULL IDENTITY,
  ParentId BIGINT NULL DEFAULT NULL,
  Title VARCHAR(75) NOT NULL,
  MetaTitle VARCHAR(100) NULL DEFAULT NULL,
  Slug VARCHAR(100) NOT NULL,
  Content VARCHAR(Max) NULL DEFAULT NULL,
  PRIMARY KEY (CategoryId));



DROP INDEX   idx_category_parent ON Blog.PostComment
CREATE INDEX idx_category_parent on Blog.Category(ParentId );



ALTER TABLE Blog.Category 
ADD CONSTRAINT fk_category_parent
  FOREIGN KEY (ParentId)
  REFERENCES Blog.Category (CategoryId)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
  



  

  CREATE TABLE Blog.PostCategory (
  PostId BIGINT NOT NULL,
  CategoryId BIGINT NOT NULL,
  PRIMARY KEY (postId, categoryId)
 ,
  CONSTRAINT fk_pc_post
    FOREIGN KEY (PostId)
    REFERENCES Blog.Post (PostId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pc_category
    FOREIGN KEY (CategoryId)
    REFERENCES Blog.Category (CategoryId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


	
DROP INDEX   idx_pc_category ON Blog.PostCategory
CREATE INDEX idx_pc_category ON Blog.PostCategory (CategoryId ASC);

	
DROP INDEX   idx_pc_post ON Blog.PostCategory
CREATE INDEX idx_pc_post ON Blog.PostCategory (PostId ASC);



  CREATE TABLE Blog.Tag (
  TagId BIGINT NOT NULL IDENTITY, 
  Title VARCHAR(75) NOT NULL,
  MetaTitle VARCHAR(100) NULL DEFAULT NULL,
  Slug VARCHAR(100) NOT NULL,
  Content VARCHAR(Max) NULL DEFAULT NULL,
  PRIMARY KEY (TagId));



  CREATE TABLE Blog.PostTag (
  PostId BIGINT NOT NULL,
  TagId BIGINT NOT NULL,
  PRIMARY KEY (PostId, TagId) ,
  CONSTRAINT fk_pt_post
    FOREIGN KEY (PostId)
    REFERENCES Blog.Post (PostId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_pt_tag
    FOREIGN KEY (PostId)
    REFERENCES Blog.Post (PostId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
