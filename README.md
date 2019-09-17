# FIK.DAL
A Simple SQL Query Generator Using ADO.NET Provider with SqlClient

Using This Library no need to write manual insert update or delete query. it also maintain Transaction.and Prevent SQL Injection.


To Use This Generate your table Model.cs Class and use this model for easy insert,update

  FIK.DAL.SQL odal = new FIK.DAL.SQL("ConnectionString");
  
  For Single Insert

        public bool Create(Counter model, ref string msg)
        {
            model.CounterID = odal.GetMaxId("CounterID", "000", "Counter", "C");
            return odal.Insert<Counter>(model, "", "", "", ref msg);
        }
  
  For Single Insert where primary key is auto generated
   
        public bool Create(Counter model, ref string msg)
        {
            return odal.Insert<Counter>(model, "", "CounterID", "", ref msg);
        }
  
  For Single Update
 

        public bool Update(Counter model, ref string msg)
        {
            // speicfy the column name you want to update and where clause for this update 
            return odal.Update<Counter>(model, "Name,MACAddress,IsActive,UpdateBy,UpdateDate", "CounterID", "", ref msg);
            }
<br>
For Single Delete<br>

        public bool Remove(Counter model, ref string msg)
        {
            return odal.Delete<Counter>(model, "CounterID", "", ref msg);
        }
  
  
 <br> If your table name and mode name are different then speicfy the customTable name parameter.
 <br> 
  
<br>If you want to insert or update two or more table at single trasaction then you can use this
  <br>
   

            var data = odal.Select<Sales>(query, ref refMsg);
            return data;
            List<Sales> model; List<Stock> oVCAList
            CompositeModel compositeModel = new CompositeModel();
            compositeModel.AddRecordSet<Sales>(model, OperationMode.Insert, "", "", "", "");
            compositeModel.AddRecordSet<Stock>(buyCentrals, OperationMode.Update, "", "-BalQty,+SQty", "PRD_ID,BranchId", "");
            compositeModel.AddRecordSet<Sales>(model[0], OperationMode.Delete, "", "", "CREATE_BY", "TempSales");
            odal.InsertUpdateComposite(compositeModel, ref msg);

<br>you can update table value with increment or decrement.
<br>you can pass any single or list model to this operation.
<br>
<br>if your model class contain a property which not need for any insert update or delete operation only need for view purpose
then you can use that property by adding following attribute.





        public Class MyModel
        {
             [FIK_NoCUDAttribute]
             public string CustomeColumn { get; set; }
        }
        
you can easily select record from database by using



        public List<Sales> GetInvoiecNo(string fromDate, string toDate)
        {
            string query = @"";
            var data = odal.Select<Sales>(query, ref refMsg);
            return data;
        }
        
        
https://www.youtube.com/watch?v=zaGHR9cI2Hs&t=3s
