using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquarium;

namespace AquariumGUI
{
    class MoveManager 
    {
        private int width;
        private int height;
        private Random randomGenerator;
        private const int MARGIN = 100;// pix
        private const int FISH_STEP = 6;
        private const int SHELLFISH_STEP = 2;


        private Image image;
        private int xPosition;
        private int yPosition;
        private int step;  
        private bool isSwiming = false;
        private bool isAerator;
        private Aquarium.AquaticOrganism organism;
        private Direction direction; 
       
        public enum Direction { UP, DOWN, LEFT, RIGHT }
      //  public enum Types { Fish, Shellfish, Seaweed};
        public int counter = 0;
 

        #region Getters and setters
        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public int XPosition
        {
            get
            {
                return xPosition;
            }

            set
            {
                xPosition = value;
            }
        }

        public int YPosition
        {
            get
            {
                return yPosition;
            }

            set
            {
                yPosition = value;
            }
        }
         
        public AquaticOrganism Organism
        {
            get
            {
                return organism;
            }

            set
            {
                organism = value;
            }
        }

      

        public bool IsAerator
        {
            get
            {
                return isAerator;
            }

            set
            {
                isAerator = value;
            }
        }

        public bool IsSwiming
        {
            get
            {
                return isSwiming;
            }

            set
            {
                isSwiming = value;
            }
        }

        #endregion
        public MoveManager( Image aImage,int aWidthOfPicture , int aHeightOfPicture, Aquarium.AquaticOrganism aOrganism) {
            this.width = aWidthOfPicture;
            this.height = aHeightOfPicture; 
            this.image = aImage;
            this.randomGenerator = new Random();
            this.organism = aOrganism;
            this.direction = Direction.LEFT;
            if (aOrganism!=null)
            {
              //  Graphics graphics;
                switch (Organism.GetType().BaseType.Name)
                {
                    case  "Fish" :
                        xPosition = randomGenerator.Next(MARGIN, width - MARGIN);
                        yPosition = randomGenerator.Next(MARGIN, height - MARGIN);
                     /*   using (graphics = Graphics.FromImage(image))
                            graphics.DrawString(aOrganism.ID.ToString(), new Font("Arial", 10), Brushes.Red, new PointF(0, 0));*/
                         
                        this.step = FISH_STEP;
                        this.IsSwiming = true; 
                        break;
                    case "Shellfish":
                        yPosition = height - Image.Height;
                        xPosition = randomGenerator.Next(MARGIN, width - MARGIN);
                      /*  using (graphics = Graphics.FromImage(image))
                            graphics.DrawString(aOrganism.ID.ToString(), new Font("Arial", 10), Brushes.Yellow, new PointF(20, 40));*/
                        this.step = SHELLFISH_STEP;
                        break;
                    case "Seaweed":
                        yPosition = height - Image.Height;
                        xPosition = randomGenerator.Next(MARGIN, width - MARGIN);
                        break;                    
                    default:
                        break;
                }
            } 
        }
        /// <summary>
        /// Constructor for aerator..
        /// </summary>
        /// <param name="aImage"></param>
        /// <param name="aWidthOfPicture"></param>
        /// <param name="aHeightOfPicture"></param>
        /// <param name="aStepInPixels"></param>
        public MoveManager( Image aImage, int aWidthOfPicture, int aHeightOfPicture, int aStepInPixels ) {
            this.width = aWidthOfPicture;
            this.height = aHeightOfPicture;
            this.step = aStepInPixels;
            this.image = aImage;
            this.direction = Direction.UP;
            xPosition = 50;
            yPosition = height - Image.Height;
            IsAerator = true; 
        }
    
        /// <summary>
        /// 
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void auto()
        { 
            if (IsAerator)
            { 
                move(direction);
            }
            else { 
                int rand = randomGenerator.Next(1, 5);
                switch (rand)
                {
                    case 1:
                        direction = Direction.UP;
                        move(direction);
                        break;
                    case 2:
                        direction = Direction.DOWN;
                        move(direction);
                        break;
                    case 3:
                        direction = Direction.LEFT;
                        move(direction);
                        break;
                    case 4:
                        direction = Direction.RIGHT;
                        move(direction);
                        break;
                    default:
                        break;
                }
            }
        }

        private void move( Direction direction )
        {
            if (direction == Direction.RIGHT &&  organism.IsMovable )
            {
                image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            switch (direction)
            {
                case Direction.UP:
                    if (isAerator)
                    {
                        if (yPosition<=0)
                        {
                            yPosition = height;
                        }
                        yPosition -= 10; 
                    } else if (!isSwiming) {
                        return;
                    } else if (yPosition <= image.Height)
                    {
                        direction = Direction.DOWN;
                        return;
                    }
                    else { 
                    yPosition -= step;
                    }
                    break;

                case Direction.DOWN:
                    if (!isSwiming)
                    {
                        return;
                    }else if (yPosition>=height-image.Height*2)
                    {
                        direction = Direction.UP;
                        return;
                    }
                    yPosition += step;
                    break;

                case Direction.LEFT:
                    if (xPosition<=MARGIN)
                    {
                        direction = Direction.RIGHT;
                        return;
                    }
                    xPosition -= step;
                    break;

                case Direction.RIGHT:
                    if (xPosition >= width-image.Width)
                    {
                        direction = Direction.LEFT;
                        return;
                    }
                    xPosition += step;
                    break;               
                default:
                    break;
            }
        }
    }
}
