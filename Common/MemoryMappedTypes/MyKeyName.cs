public enum MyKeyName
{
    Admin_level = 0,
    Amenity = 1,
    Building = 2,
    Natural = 3,
    Place = 4,
    Railway = 5,
    Boundary = 6,
    Name = 7,
    Highway = 8,
    Water = 9,
    Landuse = 10,
    Leisure = 11,
}

public class GetEnumId
{
    public static int getEnumId(string nameString)
    {
        switch (nameString)
        {
            case ("natural"):
                return 0;
            case ("place"):
                return 0;
            case ("boundary"):
                return 1;
            case ("admin_level"):
                return 2;
            case ("name"):
                return 4;
            case ("highway"):
                return 5;
            case ("water"):
                return 6;
            case ("railway"):
                return 7;
            case ("landuse"):
                return 8;
            case ("building"):
                return 9;
            case ("leisure"):
                return 10;
            case ("amenity"):
                return 11;
            case ("waterway"):
                return 12;
            default:
                return -1;
        }
    }
}

