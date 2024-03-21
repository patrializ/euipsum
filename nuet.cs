            Query query = new Query("Task")
            {
                Projection = { "category", "priority" },
                Filter = Filter.Equal("done", false)
            };
            QueryResults<Dictionary<string, object>> results = db.RunQuery(query);  
