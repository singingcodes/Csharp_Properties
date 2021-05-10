using System;
public class student
{
    public int Id { 
        get{
            return this.Id;
        }
    
     set
        {
            if (value <= 0)
        {
        throw new Exception(" id should must be greater than zero");
        }
        this.Id = value;
        }
      }
  public int PassMark { get; set; }

    public string Name { get; set; }

    // public string name
    // {
    //     set{
    //         this.name = string.IsNullOrEmpty(value) ? throw new Exception("cannot be null or empty") : value;
    //         // if(string.IsNullOrEmpty(value))
    //         // {
    //         //     throw new Exception("cannot be null or empty");
    //         // }
    //         // this.name = value;
    //     }
    //     get
    //     {
    //         return this.name;
    //     }
    // }
// public void setName( string name)
// {
//     if (string.IsNullOrEmpty(name))
//     {
//         throw new Exception("student name should not be null or empty");
//     }
//     this._name = name;
// }
// public string getName()
// {
//     return this._name;
// }
// public void setId( int id)
// {
//     if (id <= 0)
//     {
//         throw new Exception("student id should not be greater than zero");
//     }
//     this._id = id;
// }
// public int getId()
// {
//     return _id;
// }
}
