using System;

public class Speed{

    private int car_Speed;
    private int speed_Limit;
    const int demerit_Points = 5;
    int demeritPointsPerKm;
    

    public int CalculateSpeed(int carSpeed,int speedLimit){

        car_Speed = carSpeed;
        speed_Limit = speedLimit;
         demeritPointsPerKm = (carSpeed - speedLimit) / demerit_Points;
        if (demeritPointsPerKm > 12)
        {
            System.Console.WriteLine("License suspended");
        }

        else{
            if (carSpeed <= speedLimit){
                System.Console.WriteLine("Speed withing allowed limit");
            }
           else if (carSpeed > speedLimit)
            {
                System.Console.WriteLine($"Speed out of limit demerit {demeritPointsPerKm} points to the driver");
            }
            
        }
            return demeritPointsPerKm;
    }

}
