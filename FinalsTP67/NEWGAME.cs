using System;


namespace FinalsTP67
{
    public class EncapNewGame
    {
        private string Name;
        private string Gender;
        private string Sauce;
        private string Crust;
        private string Cheese;
        private string Meat;
        private string NonMeat;
        private string faceDetails;
        private string eyeColor;
        private string eyeBrow;
        private string eyeLashes;
        private string nose;
        private string lips;
        private string ears;
        private string hat;
        private string gloves;
        private string shoes;

        public EncapNewGame(string name, string gender, string sauce, string crust, string cheese, string meat, string nonmeat, string facedetails, string eyecolor, string eyebrow, string eyelashes, string nose, string lips, string ears, string hat, string gloves, string shoes)
        {
            this.Name = name;
            this.Gender = gender;
            this.Sauce = sauce;
            this.Crust = crust;
            this.Cheese = cheese;
            this.Meat = meat;
            this.NonMeat = nonmeat;
            this.faceDetails = facedetails;
            this.eyeColor = eyecolor;
            this.eyeBrow = eyebrow;
            this.eyeLashes = eyelashes;
            this.nose = nose;
            this.lips = lips;
            this.ears = ears;
            this.hat = hat;
            this.gloves = gloves;
            this.shoes = shoes;
        }

        public string getName() { return this.Name; }
        public string getGender() { return this.Gender; }
        public string getSauce() { return this.Sauce; }
        public string getCrust() { return this.Crust; }
        public string getCheese() { return this.Cheese; }
        public string getMeat() { return this.Meat; }
        public string getNonMeat() { return this.NonMeat; }
        public string getFaceDetails() { return this.faceDetails; }
        public string getEyecolor() { return this.eyeColor; }
        public string getEyeBrow() { return this.eyeBrow; }
        public string getEyeLashes() { return this.eyeLashes; }
        public string getNose() { return this.nose; }
        public string getLips() { return this.lips; }
        public string getEars() { return this.ears; }
        public string getHat() { return this.hat; }
        public string getGloves() { return this.gloves; }
        public string getShoes() { return this.shoes; }

    }
}