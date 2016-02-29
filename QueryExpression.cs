
Entity oLetter = null;
           
            try
            {

                ColumnSet columns = new ColumnSet(
                    new string[4] 
                    { 
                        "activityid", 
                        "modifiedon", 
                        "createdon", 
                        "new_myattr" 
                    });
                QueryExpression qeLastLetter = null;
                
                qeLastLetter = new QueryExpression();
                qeLastLetter.EntityName = "letter";


                qeLastLetter.Orders.Add(new OrderExpression("createdon", OrderType.Descending));

                qeLastLetter.PageInfo.Count = 1;
                qeLastLetter.PageInfo.PageNumber = 1;


                qeLastLetter.ColumnSet = columns;
                
                ConditionExpression conditionAssociationName = new ConditionExpression();
                conditionAssociationName.AttributeName = "new_barcode";
                conditionAssociationName.Operator = ConditionOperator.NotNull;
                
                FilterExpression filterRetrieve = new FilterExpression();
                filterRetrieve.FilterOperator = LogicalOperator.And;
                filterRetrieve.AddCondition(conditionAssociationName);
                
                qeLastLetter.Criteria = filterRetrieve;
                
                EntityCollection collection = service.RetrieveMultiple(qeLastLetter);
                
                if (collection.Entities.Count>0)
                 

