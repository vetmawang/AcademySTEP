using System.Collections.Generic;

namespace ToDoList
{
    class ToDoList:ITable
    {

        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string DeadLine { get; private set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Uri { get; private set; }
        static public string TableName = "todolist";
        public List<string> ColumnNames { get; private set; }

        public List<string> GetColumnNames()
        {
            return ColumnNames;
        }
        public string GetTableName()
        {
            return TableName;
        }
        public List<string> GetData()
        {
            List<string> userData = new List<string>();
            if (Id == null)
                Id = "NULL";
            userData.Add(Id);
            userData.Add(UserId);
            userData.Add(Name);
            userData.Add(Note);
            userData.Add(DeadLine);
            userData.Add(Status);
            userData.Add(Priority);
            userData.Add(Uri); 
            return userData;
        }
 
        private void SetColumnNames()
        {
            ColumnNames = new List<string>();
            ColumnNames.Add("id");
            ColumnNames.Add("userId");
            ColumnNames.Add("name");
            ColumnNames.Add("note");
            ColumnNames.Add("deadLine");
            ColumnNames.Add("status");
            ColumnNames.Add("priority");
            ColumnNames.Add("url");
        }
        public ToDoList(
      // string Id,
      string UserId,
      string Name,
      string Note,
      string DeadLine,
      string Status,
      string Priority,
      string Uri
            )
        {
            // this.Id = Id;
            this.UserId = UserId;
            this.Name = Name;
            this.Note = Note;
            this.DeadLine = DeadLine;
            this.Status = Status;
            this.Priority = Priority;
            this.Uri = Uri;

            SetColumnNames();
        }

        public ToDoList(List<string> UserData)
        {
            GetDataFromList(UserData);
            SetColumnNames();
        }
        public void GetDataFromList(List<string> UserData)
        {
            Id = UserData[0];
            UserId = UserData[1];
            Name = UserData[2];
            Note = UserData[3];
            DeadLine = UserData[4];
            Status = UserData[5];
            Priority = UserData[6];
            Uri = UserData[7];

        }
    }

}
