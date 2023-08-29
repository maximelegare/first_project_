namespace Algorithms;

using System;
using System.Text.RegularExpressions;

public class Name
{
    private string _firstName;
    private string _lastName;

    public Name(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    private bool constainsNumber(string word){
        string digits =  "0123456789";
        foreach (char digit in digits){
            if(word.IndexOf(digit) != -1){
                return true;
            }
        }
        return false;
    }

    public bool IsValid(){
        if(constainsNumber(this._firstName) || constainsNumber(this._lastName)){
            return false;
        }
        return this._firstName.Length > 1 && this._lastName.Length > 1;
    }

    public string FullName => _firstName + " " + _lastName;
}

public class PhoneNumber {


    private string _phoneNumber;
    public PhoneNumber(string PhoneNumber){
        this._phoneNumber = PhoneNumber;
    } 

    public string phoneNumber => _phoneNumber;

}

public class PostalCode {

    private string _postalCode;
    public PostalCode(string PostalCode){
        this._postalCode = PostalCode;
    }

    public bool IsValid(){
        Regex rx = new Regex(@"^[A-Z]\d[A-Z] \d[A-Z]\d$", RegexOptions.IgnoreCase);
        return rx.Match(this.postalCode).Success;
    }

    public string postalCode => _postalCode;

}


public class Identification
{
    private Name _name;
    private PhoneNumber _phoneNumber;
    private PostalCode _postalCode;
    public Identification(string FirstName, string LastName, string PhoneNumber, string PostalCode)
    {
        this._name = new Name(FirstName, LastName);
        this._phoneNumber = new PhoneNumber(PhoneNumber);
        this._postalCode = new PostalCode(PostalCode);
    }

    public string Name => _name.FullName;
    public string PhoneNumber => _phoneNumber.phoneNumber;
    public string PostalCode => _postalCode.postalCode;




}
