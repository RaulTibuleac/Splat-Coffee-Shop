//This Is our interface
//It acts a socket between two bit of code

//Think of It like a type C charger
//It doesnt matter what It Is plugged Into, as long as:
//It has a type C port.
public interface IClickable
{
    // and then It will look for this piece of code
    //on the other code block
    void OnClick();

    //What happenes If It doesnt find It?
}