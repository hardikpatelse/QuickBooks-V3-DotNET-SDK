﻿////*********************************************************
// <copyright file="IntuitBatchResponse.cs" company="Intuit">
//     Copyright (c) Intuit. All rights reserved.
// </copyright>
// <summary>This file contains code related to the batch operation.</summary>
////*********************************************************

namespace Intuit.Ipp.DataService
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Intuit.Ipp.Data;
    using Intuit.Ipp.Exception;

    /// <summary>
    /// This class processes the batch request.
    /// </summary>
   public class IntuitBatchResponse
   {
     /// <summary>
     /// unique batch item Id
     /// </summary>
     private string batchItemId;

      /// <summary>
     /// enum representing ResponseType after batch execution.
     /// </summary>
     private ResponseType responseType;

     /// <summary>
     /// entity in case response type is entity.
     /// </summary>
     private IEntity entity;

     /// <summary>
     ///  list of entities in case ResponseType is query.
     /// </summary>
     private List<IEntity> entities;

     /// <summary>
     /// IdsException in case of ResponseType is exception. 
     /// </summary>
     private IdsException exception;

     /// <summary>
     /// IntuitCDCResponse in case of ResponseType is exception. 
     /// </summary>
     private IntuitCDCResponse cdcResponse;

     #region constructor

     /// <summary>
     /// Initializes a new instance of the <see cref="IntuitBatchResponse"/> class.
     /// </summary>
     public IntuitBatchResponse()
     {
        this.entities = new List<IEntity>();
     }
     #endregion 

     #region properties

     /// <summary>
     ///  Gets or sets entity in case ResponseType is entity.
     /// </summary>
     public IEntity Entity
     {
       get { return this.entity; }
       set { this.entity = value; }
     }
   
     /// <summary>
     /// Gets list of entites in case ResponseType is Report.
     /// </summary>
     public ReadOnlyCollection<IEntity> Entities
     {
         get { return new ReadOnlyCollection<IEntity>(this.entities); }
     }

     /// <summary>
     /// Gets or sets exception in case ResponseType is exception
     /// </summary>
     public IdsException Exception
     {
         get { return this.exception; }
         set { this.exception = value; }
     }

     /// <summary>
     /// Gets or sets the type of the response return after batch execution
     /// </summary>
     public ResponseType ResponseType
     {
         get { return this.responseType; }
         set { this.responseType = value; }
     }

     /// <summary>
     /// Gets or sets the type of the response return after batch execution
     /// </summary>
     public string Id
     {
         get { return this.batchItemId; }
         set { this.batchItemId = value; }
     }

     /// <summary>
     /// Gets or sets the IntuitCDCResponse returned after batch execution
     /// </summary>
     public IntuitCDCResponse CDCResponse
     {
         get { return this.cdcResponse; }
         set { this.cdcResponse = value; }
     }

     #endregion 

     /// <summary>
     /// adds the entities to entities list
     /// </summary>
     /// <param name="entity">The entity.</param>
     internal void AddEntities(IEntity entity)
     {
         this.entities.Add(entity);
     }
    }
}