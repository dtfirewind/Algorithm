using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class DrawLine
    {
        public void FillBits(byte[] screen, int width, int x1, int x2, int y)
        {
            int start_offset = x1 % 8;
            int start_full_byte = x1 / 8;
            // if(start_offset != 0){
            //     start_full_byte++;
            // }

            int end_offset = x2 % 8;
            int end_full_byte = x2 / 8;
            // if(end_offset != 7){
            //     end_full_byte--;
            // }

            for(int b = start_full_byte; b < end_full_byte; b++)
            {
                screen[(width/8) * y + b] = (byte)0xff;
            }

            int start_mask = (byte) (0xff >> start_offset);
            int end_mask = (byte) ~(0xff >> (end_offset + 1));

            screen[(width/8) * y + start_full_byte] |= (byte)start_mask;
            screen[(width/8) * y + end_full_byte] |= (byte)end_mask;
        }
    }

}