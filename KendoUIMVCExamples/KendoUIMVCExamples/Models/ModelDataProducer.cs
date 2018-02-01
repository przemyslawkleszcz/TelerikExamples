using System.Collections.Generic;

namespace KendoUIMVCExamples.Models
{
    public class ModelDataProducer
    {
        public static IndexModel PrepareIndexModel()
        {
            var model = new IndexModel {Data = PrepareIndexData()};
            return model;
        }

        //Assembly asm = Assembly.GetExecutingAssembly();

        //asm.GetTypes()
        //.Where(type=> typeof(Controller).IsAssignableFrom(type)) //filter controllers
        //    .SelectMany(type => type.GetMethods())
        //    .Where(method => method.IsPublic && ! method.IsDefined(typeof(NonActionAttribute)));

        private static IEnumerable<IndexData> PrepareIndexData()
        {
            var data = new List<IndexData>
            {
                new IndexData
                {
                    Id = 1,
                    Name = "ServerBinding"
                },
                new IndexData
                {
                    Id = 2,
                    Name = "AjaxBinding"
                },
                new IndexData
                {
                    Id = 3,
                    Name = "ServerTemplate"
                },
                new IndexData
                {
                    Id = 4,
                    Name = "ClientTemplate"
                },
                new IndexData
                {
                    Id = 5,
                    Name = "DisplayFormatAttribute"
                },
                new IndexData
                {
                    Id = 6,
                    Name = "TreeListCellColorChange"
                }
            };

            return data;
        }

        public static T PrepareModel<T, W>()
            where T : BaseModel, new()
            where W : BaseData, new()
        {
            var model = new T
            {
                Data = PrepareData<W>()
            };

            return model;
        }

        private static IEnumerable<T> PrepareData<T>() where T : BaseData, new()
        {
            var data = new List<T>
            {
                new T
                {
                    Id = 1,
                    Name = "AAA"
                },
                new T
                {
                    Id = 2,
                    Name = "BBB"
                }
            };

            return data;
        }
    }
}