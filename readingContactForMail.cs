    string email = "";
    var mail ="";
    var id ="";
    var esqTransaction = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "UsrTransaction");
   
    var modifiedOnColumn = esqTransaction.AddColumn("CreatedOn");
    modifiedOnColumn.OrderByDesc(0);
    var emailColumn = esqTransaction.AddColumn("UsrContactTransaction.Email").Name;
    var mailColumn = esqTransaction.AddColumn("UsrComment").Name;
    var idColumn = esqTransaction.AddColumn("Id").Name;
 
    
    var resultEntities = esqTransaction.GetEntityCollection(UserConnection);
    
    id = resultEntities[0].GetColumnValue(idColumn).ToString();
    email = resultEntities[0].GetColumnValue(emailColumn).ToString();
    mail = resultEntities[0].GetColumnValue(mailColumn).ToString();

    Set<bool>("ProcessSchemaMailIsNull", string.IsNullOrEmpty(email));
    Set<string>("ProcessSchemaid", id);
    Set<string>("ProcessSchemaEmail", email.Trim());
    Set<string>("ProcessSchemaMail", mail);

return true;
