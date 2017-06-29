using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ServiceInterface
    {
        [OperationContract]
        String GetData(int value);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceLibrary.ContractType".
    [DataContract]
    public class user
    {
        int id = 0;
        string name = "";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    [DataContract]
    public class Recipe
    {
        int id = 0;
        string name = "";
        string description = "";

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
    [DataContract]
    public class RecipeContent
    {
        int recipeId = 0;
        int productId = 0;
        double amount = 0;
        string measureMethod = "";

        [DataMember]
        public int RecipeId
        {
            get { return recipeId; }
            set { recipeId = value; }
        }
        [DataMember]
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        [DataMember]
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        [DataMember]
        public string MeasureMethod
        {
            get { return measureMethod; }
            set { measureMethod = value; }
        }
    }
    [DataContract]
    public class Product
    {
        int id = 0;
        string name = "";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    [DataContract]
    public class UserMade
    {
        int userid = 0;
        int recipeid = 0;
        int timesMade = 0;

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        [DataMember]
        public int Recipeid
        {
            get { return recipeid; }
            set { recipeid = value; }
        }
        [DataMember]
        public int TimesMade
        {
            get { return timesMade; }
            set { timesMade = value; }
        }
    }
}
