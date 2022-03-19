
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace _2022Hackathon.DA.ADO
{
    public interface IMapping<TData, TModel>
    where TData : DbDataReader
    {
        public Command Mapping(TModel model, CRUD type);
        public TModel Mapping(TData data);
    }
    public interface IMapping<TData, TModel, TForm>
        where TData : DbDataReader
    {
        public Command Mapping(TForm form, CRUD type);
        public TModel Mapping(TData data);
    }
}
