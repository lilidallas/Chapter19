﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("PlanetWroxModel", "FK_Review_Genre", "Genre", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PlanetWroxModel.Genre), "Review", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PlanetWroxModel.Review), true)]
[assembly: EdmRelationshipAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "PhotoAlbum", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(PlanetWroxModel.PhotoAlbum), "Picture", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(PlanetWroxModel.Picture), true)]

#endregion

namespace PlanetWroxModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PlanetWroxEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PlanetWroxEntities object using the connection string found in the 'PlanetWroxEntities' section of the application configuration file.
        /// </summary>
        public PlanetWroxEntities() : base("name=PlanetWroxEntities", "PlanetWroxEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PlanetWroxEntities object.
        /// </summary>
        public PlanetWroxEntities(string connectionString) : base(connectionString, "PlanetWroxEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PlanetWroxEntities object.
        /// </summary>
        public PlanetWroxEntities(EntityConnection connection) : base(connection, "PlanetWroxEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Genre> Genres
        {
            get
            {
                if ((_Genres == null))
                {
                    _Genres = base.CreateObjectSet<Genre>("Genres");
                }
                return _Genres;
            }
        }
        private ObjectSet<Genre> _Genres;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Review> Reviews
        {
            get
            {
                if ((_Reviews == null))
                {
                    _Reviews = base.CreateObjectSet<Review>("Reviews");
                }
                return _Reviews;
            }
        }
        private ObjectSet<Review> _Reviews;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PhotoAlbum> PhotoAlbums
        {
            get
            {
                if ((_PhotoAlbums == null))
                {
                    _PhotoAlbums = base.CreateObjectSet<PhotoAlbum>("PhotoAlbums");
                }
                return _PhotoAlbums;
            }
        }
        private ObjectSet<PhotoAlbum> _PhotoAlbums;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Picture> Pictures
        {
            get
            {
                if ((_Pictures == null))
                {
                    _Pictures = base.CreateObjectSet<Picture>("Pictures");
                }
                return _Pictures;
            }
        }
        private ObjectSet<Picture> _Pictures;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Genres EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGenres(Genre genre)
        {
            base.AddObject("Genres", genre);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Reviews EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToReviews(Review review)
        {
            base.AddObject("Reviews", review);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PhotoAlbums EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPhotoAlbums(PhotoAlbum photoAlbum)
        {
            base.AddObject("PhotoAlbums", photoAlbum);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pictures EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPictures(Picture picture)
        {
            base.AddObject("Pictures", picture);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlanetWroxModel", Name="Genre")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Genre : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Genre object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="sortOrder">Initial value of the SortOrder property.</param>
        public static Genre CreateGenre(global::System.Int32 id, global::System.String name, global::System.Int32 sortOrder)
        {
            Genre genre = new Genre();
            genre.Id = id;
            genre.Name = name;
            genre.SortOrder = sortOrder;
            return genre;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SortOrder
        {
            get
            {
                return _SortOrder;
            }
            set
            {
                OnSortOrderChanging(value);
                ReportPropertyChanging("SortOrder");
                _SortOrder = StructuralObject.SetValidValue(value, "SortOrder");
                ReportPropertyChanged("SortOrder");
                OnSortOrderChanged();
            }
        }
        private global::System.Int32 _SortOrder;
        partial void OnSortOrderChanging(global::System.Int32 value);
        partial void OnSortOrderChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Review_Genre", "Review")]
        public EntityCollection<Review> Reviews
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Review>("PlanetWroxModel.FK_Review_Genre", "Review");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Review>("PlanetWroxModel.FK_Review_Genre", "Review", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlanetWroxModel", Name="PhotoAlbum")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PhotoAlbum : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PhotoAlbum object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static PhotoAlbum CreatePhotoAlbum(global::System.Int32 id, global::System.String name)
        {
            PhotoAlbum photoAlbum = new PhotoAlbum();
            photoAlbum.Id = id;
            photoAlbum.Name = name;
            return photoAlbum;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true, "UserName");
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "Picture")]
        public EntityCollection<Picture> Pictures
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Picture>("PlanetWroxModel.FK_Picture_PhotoAlbum", "Picture");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Picture>("PlanetWroxModel.FK_Picture_PhotoAlbum", "Picture", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlanetWroxModel", Name="Picture")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Picture : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Picture object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="toolTip">Initial value of the ToolTip property.</param>
        /// <param name="imageUrl">Initial value of the ImageUrl property.</param>
        /// <param name="photoAlbumId">Initial value of the PhotoAlbumId property.</param>
        public static Picture CreatePicture(global::System.Int32 id, global::System.String description, global::System.String toolTip, global::System.String imageUrl, global::System.Int32 photoAlbumId)
        {
            Picture picture = new Picture();
            picture.Id = id;
            picture.Description = description;
            picture.ToolTip = toolTip;
            picture.ImageUrl = imageUrl;
            picture.PhotoAlbumId = photoAlbumId;
            return picture;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ToolTip
        {
            get
            {
                return _ToolTip;
            }
            set
            {
                OnToolTipChanging(value);
                ReportPropertyChanging("ToolTip");
                _ToolTip = StructuralObject.SetValidValue(value, false, "ToolTip");
                ReportPropertyChanged("ToolTip");
                OnToolTipChanged();
            }
        }
        private global::System.String _ToolTip;
        partial void OnToolTipChanging(global::System.String value);
        partial void OnToolTipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ImageUrl
        {
            get
            {
                return _ImageUrl;
            }
            set
            {
                OnImageUrlChanging(value);
                ReportPropertyChanging("ImageUrl");
                _ImageUrl = StructuralObject.SetValidValue(value, false, "ImageUrl");
                ReportPropertyChanged("ImageUrl");
                OnImageUrlChanged();
            }
        }
        private global::System.String _ImageUrl;
        partial void OnImageUrlChanging(global::System.String value);
        partial void OnImageUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PhotoAlbumId
        {
            get
            {
                return _PhotoAlbumId;
            }
            set
            {
                OnPhotoAlbumIdChanging(value);
                ReportPropertyChanging("PhotoAlbumId");
                _PhotoAlbumId = StructuralObject.SetValidValue(value, "PhotoAlbumId");
                ReportPropertyChanged("PhotoAlbumId");
                OnPhotoAlbumIdChanged();
            }
        }
        private global::System.Int32 _PhotoAlbumId;
        partial void OnPhotoAlbumIdChanging(global::System.Int32 value);
        partial void OnPhotoAlbumIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Picture_PhotoAlbum", "PhotoAlbum")]
        public PhotoAlbum PhotoAlbum
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PhotoAlbum>("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PhotoAlbum>("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<PhotoAlbum> PhotoAlbumReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PhotoAlbum>("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PhotoAlbum>("PlanetWroxModel.FK_Picture_PhotoAlbum", "PhotoAlbum", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlanetWroxModel", Name="Review")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Review : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Review object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="summary">Initial value of the Summary property.</param>
        /// <param name="genreId">Initial value of the GenreId property.</param>
        /// <param name="authorized">Initial value of the Authorized property.</param>
        /// <param name="createDateTime">Initial value of the CreateDateTime property.</param>
        /// <param name="updateDateTime">Initial value of the UpdateDateTime property.</param>
        public static Review CreateReview(global::System.Int32 id, global::System.String title, global::System.String summary, global::System.Int32 genreId, global::System.Boolean authorized, global::System.DateTime createDateTime, global::System.DateTime updateDateTime)
        {
            Review review = new Review();
            review.Id = id;
            review.Title = title;
            review.Summary = summary;
            review.GenreId = genreId;
            review.Authorized = authorized;
            review.CreateDateTime = createDateTime;
            review.UpdateDateTime = updateDateTime;
            return review;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Summary
        {
            get
            {
                return _Summary;
            }
            set
            {
                OnSummaryChanging(value);
                ReportPropertyChanging("Summary");
                _Summary = StructuralObject.SetValidValue(value, false, "Summary");
                ReportPropertyChanged("Summary");
                OnSummaryChanged();
            }
        }
        private global::System.String _Summary;
        partial void OnSummaryChanging(global::System.String value);
        partial void OnSummaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Body
        {
            get
            {
                return _Body;
            }
            set
            {
                OnBodyChanging(value);
                ReportPropertyChanging("Body");
                _Body = StructuralObject.SetValidValue(value, true, "Body");
                ReportPropertyChanged("Body");
                OnBodyChanged();
            }
        }
        private global::System.String _Body;
        partial void OnBodyChanging(global::System.String value);
        partial void OnBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GenreId
        {
            get
            {
                return _GenreId;
            }
            set
            {
                OnGenreIdChanging(value);
                ReportPropertyChanging("GenreId");
                _GenreId = StructuralObject.SetValidValue(value, "GenreId");
                ReportPropertyChanged("GenreId");
                OnGenreIdChanged();
            }
        }
        private global::System.Int32 _GenreId;
        partial void OnGenreIdChanging(global::System.Int32 value);
        partial void OnGenreIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Authorized
        {
            get
            {
                return _Authorized;
            }
            set
            {
                OnAuthorizedChanging(value);
                ReportPropertyChanging("Authorized");
                _Authorized = StructuralObject.SetValidValue(value, "Authorized");
                ReportPropertyChanged("Authorized");
                OnAuthorizedChanged();
            }
        }
        private global::System.Boolean _Authorized;
        partial void OnAuthorizedChanging(global::System.Boolean value);
        partial void OnAuthorizedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDateTime
        {
            get
            {
                return _CreateDateTime;
            }
            set
            {
                OnCreateDateTimeChanging(value);
                ReportPropertyChanging("CreateDateTime");
                _CreateDateTime = StructuralObject.SetValidValue(value, "CreateDateTime");
                ReportPropertyChanged("CreateDateTime");
                OnCreateDateTimeChanged();
            }
        }
        private global::System.DateTime _CreateDateTime;
        partial void OnCreateDateTimeChanging(global::System.DateTime value);
        partial void OnCreateDateTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime UpdateDateTime
        {
            get
            {
                return _UpdateDateTime;
            }
            set
            {
                OnUpdateDateTimeChanging(value);
                ReportPropertyChanging("UpdateDateTime");
                _UpdateDateTime = StructuralObject.SetValidValue(value, "UpdateDateTime");
                ReportPropertyChanged("UpdateDateTime");
                OnUpdateDateTimeChanged();
            }
        }
        private global::System.DateTime _UpdateDateTime;
        partial void OnUpdateDateTimeChanging(global::System.DateTime value);
        partial void OnUpdateDateTimeChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlanetWroxModel", "FK_Review_Genre", "Genre")]
        public Genre Genre
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("PlanetWroxModel.FK_Review_Genre", "Genre").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("PlanetWroxModel.FK_Review_Genre", "Genre").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Genre> GenreReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Genre>("PlanetWroxModel.FK_Review_Genre", "Genre");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Genre>("PlanetWroxModel.FK_Review_Genre", "Genre", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
