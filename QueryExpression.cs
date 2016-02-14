
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
