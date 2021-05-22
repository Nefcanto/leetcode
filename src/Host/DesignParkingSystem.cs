public class ParkingSystem {
    int bigs = 0;
    int mediums = 0;
    int smalls = 0;

    public ParkingSystem(int big, int medium, int small) {
        this.bigs = big;
        this.mediums = medium;
        this.smalls = small;
    }
    
    public bool AddCar(int carType) {
        switch (carType) {
            case 1:
                if (bigs >= 1) {
                    bigs--;
                    return true;
                }
                return false;
            case 2:
                if (mediums >= 1) {
                    mediums--;
                    return true;
                }
                return false;
            case 3:
                if (smalls >= 1) {
                    smalls--;
                    return true;
                }
                return false;
        }
        return false;
    }
}