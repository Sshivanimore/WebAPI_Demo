namespace WebAPI_Demo.Model.Repositories
{
    public static class ShirtRepository
    {

        private static List<ShirtsModel> shirts = new List<ShirtsModel>() {
            new ShirtsModel{shirtId =1, Brand="XYZ", Color="red", gender="men", size=20},
            new ShirtsModel{shirtId =2, Brand="XYZ", Color="yellow", gender="men", size=15},
            new ShirtsModel{shirtId =3, Brand="XYZ", Color="green", gender="women", size=10},
            new ShirtsModel{shirtId =4, Brand="XYZ", Color="red", gender="women", size=4},
            new ShirtsModel{shirtId =5, Brand="XYZ", Color="black", gender="men", size=5},
            new ShirtsModel{shirtId =6, Brand="XYZ", Color="red", gender="women", size=3}

        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.shirtId == id);    
        }

        public static ShirtsModel? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.shirtId == id);
        }

    }
}
