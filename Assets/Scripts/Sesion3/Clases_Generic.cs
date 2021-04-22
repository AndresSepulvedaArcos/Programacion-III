using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    public float maxSpeed = 120;
    private int numberTires = 4;
    public float gasAmmount;
    public bool hasDiesel;
    public Color color;
    public string brand;
    
    protected string internalLicensePlate;
    public string licensePlate { get { return internalLicensePlate; } }


    public Car()
    {
        internalLicensePlate = "AA1111";
        color = Color.black;
        gasAmmount = 100;
    }

    public Car(string NewLicensePlate)
    {
        internalLicensePlate = NewLicensePlate;

    }
    public Car(string NewLicensePlate,Color NewColor)
    {
        internalLicensePlate = NewLicensePlate;
        color = NewColor;
    }
    public void SetLicensePlate(string NewLicensePlate)
    {
        internalLicensePlate = NewLicensePlate;
    }

    public virtual void MoveForward()
    {
        if (gasAmmount <= 0)
            return;

            gasAmmount -= Time.deltaTime;

        Debug.Log("Car with license plate "+ internalLicensePlate +" Moving forward GAS : " + gasAmmount);

      
    }

    public void Brake()
    {
        Debug.Log("Braking");
    }

    public void Turn(bool turnLeft)
    {
        Debug.Log("Turn" + turnLeft);
    }
}

public class ElectricCar:Car
{

    public bool isElectric;
    public float charge;

    public ElectricCar()
    {

    }

    public ElectricCar(string NewLicensePlate)
    {

        internalLicensePlate = NewLicensePlate;
        hasDiesel = false;
        isElectric = true;
        charge = 100;

    }

    public override void MoveForward() 
    {
        if (charge <= 0)
            return;

        charge -= Time.deltaTime;

        Debug.Log("Car with license plate " + internalLicensePlate + " Moving forward ==> CHARGE " + charge);


    }
}

public class PlasmaCar : ElectricCar
{

  
    public PlasmaCar(string NewLicensePlate)
    {
        charge = 100;

        internalLicensePlate = NewLicensePlate;
       

    }

    public override void MoveForward()
    {
        base.MoveForward();

        Debug.Log("y ademas vuela");
    }
}

public class Clases_Generic : MonoBehaviour
{
    Car audi;
    ElectricCar tesla;
    PlasmaCar pepitosCar;
    // Start is called before the first frame update
    void Start()
    {
          audi = new Car();
        Car citroen = new Car("HY3421");
        Car peugeot = new Car("PE8765", Color.red);
        

        Debug.Log(audi.licensePlate);
        Debug.Log(citroen.licensePlate);
        Debug.Log(peugeot.licensePlate);

        tesla = new ElectricCar("JU7253");
        pepitosCar = new PlasmaCar("PEPITO");


    }
    private void Update()
    {

    //    audi.MoveForward();
      //  tesla.MoveForward();
        pepitosCar.MoveForward();

    }


}
