class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 40;
    }
    
    public int RemainingMinutesInOven(int actualMinsInOven){
        return ExpectedMinutesInOven() - actualMinsInOven;
    }

    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    
    public int ElapsedTimeInMinutes(int layers, int actualMinsInOven){
        return PreparationTimeInMinutes(layers) + actualMinsInOven;
    }
}
