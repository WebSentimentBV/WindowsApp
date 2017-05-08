﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSentiment.Classes
{
    public class Service
    {
        //VARIABLES
        public int serviceID { get; set; }
        public string serviceTitle { get; set; }
        public string serviceText { get; set; }
        public byte[] serviceImage { get; set; }

        //CONSTRUCTOR
        public Service()
        {

        }
        public Service(int serviceID, string serviceTitle, string serviceText, byte[] serviceImage)
        {
            this.serviceID = serviceID;
            this.serviceTitle = serviceTitle;
            this.serviceText = serviceText;
            this.serviceImage = serviceImage;
        }

        public void InsertServices(SQLiteConnection con)
        {
            byte[] imgEmpty = new byte[] { };
            //byte[] imgCross = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 225, 0, 88, 69, 120, 105, 102, 0, 0, 77, 77, 0, 42, 0, 0, 0, 8, 0, 4, 1, 49, 0, 2, 0, 0, 0, 17, 0, 0, 0, 62, 81, 16, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 81, 17, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 81, 18, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 65, 100, 111, 98, 101, 32, 73, 109, 97, 103, 101, 82, 101, 97, 100, 121, 0, 0, 255, 219, 0, 67, 0, 8, 6, 6, 7, 6, 5, 8, 7, 7, 7, 9, 9, 8, 10, 12, 20, 13, 12, 11, 11, 12, 25, 18, 19, 15, 20, 29, 26, 31, 30, 29, 26, 28, 28, 32, 36, 46, 39, 32, 34, 44, 35, 28, 28, 40, 55, 41, 44, 48, 49, 52, 52, 52, 31, 39, 57, 61, 56, 50, 60, 46, 51, 52, 50, 255, 219, 0, 67, 1, 9, 9, 9, 12, 11, 12, 24, 13, 13, 24, 50, 33, 28, 33, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 255, 192, 0, 17, 8, 0, 70, 0, 70, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 249, 254, 172, 90, 216, 94, 95, 111, 251, 37, 164, 247, 27, 49, 187, 202, 140, 190, 220, 244, 206, 58, 116, 53, 94, 189, 103, 194, 147, 38, 157, 240, 253, 111, 86, 21, 102, 142, 57, 166, 117, 31, 46, 242, 172, 221, 79, 174, 20, 12, 251, 87, 38, 55, 18, 240, 244, 212, 162, 174, 219, 177, 217, 130, 195, 71, 17, 81, 198, 78, 201, 43, 158, 109, 253, 131, 172, 255, 0, 208, 38, 255, 0, 255, 0, 1, 159, 252, 40, 254, 193, 214, 127, 232, 19, 127, 255, 0, 128, 207, 254, 21, 217, 127, 194, 208, 255, 0, 168, 63, 254, 76, 255, 0, 246, 20, 127, 194, 208, 255, 0, 168, 63, 254, 76, 255, 0, 246, 21, 207, 237, 241, 255, 0, 243, 233, 125, 235, 252, 206, 159, 171, 224, 63, 231, 235, 251, 159, 249, 28, 111, 246, 14, 179, 255, 0, 64, 155, 255, 0, 252, 6, 127, 240, 163, 251, 7, 89, 255, 0, 160, 77, 255, 0, 254, 3, 63, 248, 87, 101, 255, 0, 11, 67, 254, 160, 255, 0, 249, 51, 255, 0, 216, 81, 255, 0, 11, 67, 254, 160, 255, 0, 249, 51, 255, 0, 216, 81, 237, 241, 255, 0, 243, 233, 125, 235, 252, 195, 234, 248, 15, 249, 250, 254, 231, 254, 71, 27, 253, 131, 172, 255, 0, 208, 38, 255, 0, 255, 0, 1, 159, 252, 42, 27, 157, 50, 254, 202, 49, 37, 213, 141, 204, 17, 147, 180, 52, 177, 50, 130, 125, 50, 71, 94, 43, 184, 255, 0, 133, 161, 255, 0, 80, 127, 252, 153, 255, 0, 236, 43, 165, 213, 158, 61, 91, 193, 23, 55, 18, 197, 133, 154, 199, 237, 1, 55, 31, 149, 182, 239, 28, 241, 156, 16, 63, 42, 206, 88, 236, 77, 41, 71, 219, 83, 178, 110, 219, 151, 12, 6, 26, 172, 101, 236, 106, 93, 165, 125, 143, 24, 162, 138, 43, 215, 60, 112, 174, 251, 76, 241, 30, 147, 111, 224, 23, 211, 37, 187, 219, 120, 109, 231, 65, 31, 150, 231, 230, 98, 248, 25, 198, 59, 142, 245, 107, 192, 158, 26, 177, 151, 72, 254, 210, 189, 183, 138, 230, 75, 130, 194, 53, 145, 67, 170, 32, 56, 232, 70, 50, 72, 60, 243, 198, 58, 115, 86, 191, 182, 188, 9, 255, 0, 60, 172, 63, 240, 0, 255, 0, 241, 21, 226, 226, 241, 48, 173, 47, 100, 161, 41, 114, 190, 157, 255, 0, 19, 219, 194, 97, 103, 66, 10, 171, 156, 99, 206, 186, 246, 252, 15, 45, 162, 189, 75, 251, 107, 192, 159, 243, 202, 195, 255, 0, 0, 15, 255, 0, 17, 87, 99, 211, 60, 55, 226, 77, 34, 228, 105, 214, 214, 129, 91, 49, 9, 227, 182, 216, 209, 190, 1, 4, 112, 15, 25, 7, 223, 165, 107, 44, 205, 195, 89, 210, 146, 93, 218, 50, 142, 86, 167, 165, 58, 177, 111, 178, 103, 144, 81, 69, 21, 234, 158, 72, 87, 177, 255, 0, 205, 58, 255, 0, 184, 79, 254, 210, 175, 28, 175, 99, 255, 0, 154, 117, 255, 0, 112, 159, 253, 165, 94, 70, 109, 255, 0, 46, 253, 79, 103, 40, 255, 0, 151, 190, 135, 142, 81, 69, 21, 235, 158, 49, 236, 126, 7, 255, 0, 145, 58, 195, 254, 218, 127, 232, 198, 175, 28, 175, 99, 240, 63, 252, 137, 214, 31, 246, 211, 255, 0, 70, 53, 120, 229, 121, 25, 119, 251, 197, 127, 95, 213, 158, 206, 101, 254, 239, 135, 244, 253, 16, 87, 169, 124, 53, 255, 0, 145, 118, 227, 254, 190, 219, 255, 0, 64, 74, 242, 218, 245, 47, 134, 191, 242, 46, 220, 127, 215, 219, 127, 232, 9, 90, 102, 255, 0, 238, 207, 213, 25, 228, 255, 0, 239, 75, 209, 158, 91, 69, 122, 151, 195, 95, 249, 23, 110, 63, 235, 237, 191, 244, 4, 174, 202, 177, 196, 102, 254, 198, 171, 167, 201, 123, 121, 255, 0, 192, 54, 195, 228, 254, 218, 148, 106, 115, 218, 254, 95, 240, 79, 158, 235, 216, 255, 0, 230, 157, 127, 220, 39, 255, 0, 105, 87, 67, 88, 94, 40, 254, 212, 159, 74, 154, 199, 75, 177, 146, 89, 39, 77, 141, 47, 153, 26, 170, 169, 251, 195, 230, 57, 36, 142, 58, 119, 206, 114, 43, 134, 182, 59, 235, 115, 132, 109, 203, 103, 213, 255, 0, 195, 29, 244, 48, 31, 83, 132, 229, 205, 205, 117, 178, 95, 240, 231, 140, 81, 86, 181, 13, 54, 243, 74, 186, 54, 215, 208, 52, 51, 0, 27, 105, 32, 228, 30, 224, 142, 15, 225, 69, 125, 52, 100, 164, 174, 157, 209, 242, 210, 139, 139, 180, 149, 153, 235, 62, 7, 255, 0, 145, 58, 195, 254, 218, 127, 232, 198, 175, 44, 254, 193, 214, 127, 232, 19, 127, 255, 0, 128, 207, 254, 21, 220, 120, 19, 196, 182, 49, 105, 31, 217, 183, 183, 17, 91, 73, 110, 88, 198, 210, 48, 69, 116, 39, 61, 73, 198, 65, 39, 142, 56, 199, 94, 107, 172, 254, 222, 209, 191, 232, 45, 97, 255, 0, 129, 41, 254, 53, 243, 158, 222, 182, 19, 17, 86, 208, 191, 51, 255, 0, 63, 243, 62, 151, 216, 80, 198, 97, 233, 94, 118, 229, 86, 252, 191, 200, 241, 191, 236, 29, 103, 254, 129, 55, 255, 0, 248, 12, 255, 0, 225, 94, 147, 240, 254, 210, 230, 203, 65, 158, 59, 171, 121, 160, 144, 221, 51, 5, 149, 10, 146, 54, 175, 56, 63, 74, 210, 177, 214, 116, 248, 44, 227, 138, 239, 196, 22, 23, 83, 174, 119, 77, 230, 198, 155, 185, 56, 249, 65, 192, 192, 192, 252, 40, 191, 241, 70, 145, 103, 97, 61, 194, 106, 22, 147, 188, 104, 74, 197, 28, 234, 89, 219, 176, 24, 201, 228, 247, 199, 29, 106, 113, 88, 186, 248, 152, 251, 30, 78, 190, 127, 169, 88, 76, 29, 12, 52, 189, 183, 63, 78, 182, 253, 14, 35, 194, 62, 46, 176, 208, 52, 153, 109, 110, 161, 185, 121, 30, 115, 32, 49, 42, 145, 130, 170, 59, 176, 231, 138, 222, 255, 0, 133, 149, 163, 127, 207, 181, 255, 0, 253, 251, 79, 254, 42, 188, 182, 138, 245, 170, 229, 152, 122, 179, 115, 149, 238, 252, 207, 34, 150, 105, 136, 165, 5, 8, 218, 203, 200, 245, 47, 248, 89, 90, 55, 252, 251, 95, 255, 0, 223, 180, 255, 0, 226, 168, 255, 0, 133, 149, 163, 127, 207, 181, 255, 0, 253, 251, 79, 254, 42, 188, 182, 138, 143, 236, 140, 55, 103, 247, 154, 127, 108, 98, 187, 175, 184, 232, 124, 91, 226, 53, 241, 13, 252, 77, 2, 73, 29, 172, 9, 136, 214, 64, 55, 18, 126, 241, 56, 233, 208, 12, 100, 244, 247, 162, 185, 234, 43, 190, 149, 40, 210, 130, 132, 54, 71, 157, 86, 172, 170, 205, 212, 158, 236, 40, 162, 138, 208, 204, 40, 162, 138, 0, 40, 162, 138, 0, 40, 162, 138, 0, 40, 162, 138, 0, 255, 217 };
            //byte[] imgScreen = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 225, 0, 88, 69, 120, 105, 102, 0, 0, 77, 77, 0, 42, 0, 0, 0, 8, 0, 4, 1, 49, 0, 2, 0, 0, 0, 17, 0, 0, 0, 62, 81, 16, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 81, 17, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 81, 18, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 65, 100, 111, 98, 101, 32, 73, 109, 97, 103, 101, 82, 101, 97, 100, 121, 0, 0, 255, 219, 0, 67, 0, 8, 6, 6, 7, 6, 5, 8, 7, 7, 7, 9, 9, 8, 10, 12, 20, 13, 12, 11, 11, 12, 25, 18, 19, 15, 20, 29, 26, 31, 30, 29, 26, 28, 28, 32, 36, 46, 39, 32, 34, 44, 35, 28, 28, 40, 55, 41, 44, 48, 49, 52, 52, 52, 31, 39, 57, 61, 56, 50, 60, 46, 51, 52, 50, 255, 219, 0, 67, 1, 9, 9, 9, 12, 11, 12, 24, 13, 13, 24, 50, 33, 28, 33, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 255, 192, 0, 17, 8, 0, 70, 0, 70, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 242, 77, 47, 192, 218, 190, 171, 96, 151, 136, 96, 130, 57, 57, 65, 59, 48, 102, 31, 222, 192, 7, 131, 219, 252, 49, 87, 127, 225, 90, 235, 63, 243, 243, 97, 255, 0, 127, 31, 255, 0, 137, 174, 222, 210, 229, 236, 188, 15, 5, 212, 97, 76, 144, 105, 171, 34, 134, 232, 72, 143, 35, 63, 149, 113, 31, 240, 178, 181, 159, 249, 246, 176, 255, 0, 191, 111, 255, 0, 197, 87, 135, 79, 19, 141, 175, 41, 123, 43, 89, 51, 222, 169, 133, 192, 208, 140, 125, 173, 238, 213, 195, 254, 21, 174, 179, 255, 0, 63, 54, 31, 247, 241, 255, 0, 248, 154, 63, 225, 90, 235, 63, 243, 243, 97, 255, 0, 127, 31, 255, 0, 137, 163, 254, 22, 86, 179, 255, 0, 62, 214, 31, 247, 237, 255, 0, 248, 170, 63, 225, 101, 107, 63, 243, 237, 97, 255, 0, 126, 223, 255, 0, 138, 173, 127, 225, 75, 200, 203, 254, 19, 60, 195, 254, 21, 174, 179, 255, 0, 63, 54, 31, 247, 241, 255, 0, 248, 154, 63, 225, 90, 235, 63, 243, 243, 97, 255, 0, 127, 31, 255, 0, 137, 169, 173, 188, 125, 226, 43, 217, 12, 118, 186, 117, 180, 242, 1, 184, 172, 80, 72, 196, 15, 92, 6, 247, 168, 127, 225, 101, 107, 63, 243, 237, 97, 255, 0, 126, 223, 255, 0, 138, 165, 124, 202, 246, 247, 66, 217, 101, 175, 239, 7, 252, 43, 93, 103, 254, 126, 108, 63, 239, 227, 255, 0, 241, 52, 127, 194, 181, 214, 127, 231, 230, 195, 254, 254, 63, 255, 0, 19, 71, 252, 44, 173, 103, 254, 125, 172, 63, 239, 219, 255, 0, 241, 85, 107, 76, 248, 129, 171, 94, 234, 214, 118, 178, 91, 217, 8, 231, 157, 35, 98, 168, 217, 0, 176, 7, 31, 55, 94, 105, 73, 230, 81, 77, 187, 14, 49, 203, 36, 210, 87, 57, 205, 115, 195, 58, 143, 135, 252, 166, 187, 17, 188, 82, 112, 37, 136, 146, 160, 255, 0, 116, 228, 12, 30, 255, 0, 254, 163, 69, 119, 63, 18, 191, 228, 93, 183, 255, 0, 175, 181, 255, 0, 208, 30, 138, 236, 192, 98, 37, 94, 138, 156, 247, 56, 179, 12, 60, 48, 245, 220, 33, 177, 163, 255, 0, 52, 235, 254, 225, 63, 251, 74, 188, 114, 189, 143, 254, 105, 215, 253, 194, 127, 246, 149, 121, 37, 135, 217, 191, 180, 109, 126, 217, 255, 0, 30, 190, 114, 121, 221, 126, 230, 70, 238, 156, 244, 207, 74, 228, 202, 221, 149, 87, 230, 118, 230, 202, 238, 146, 242, 11, 43, 11, 189, 70, 228, 91, 217, 219, 201, 60, 167, 248, 80, 103, 3, 32, 100, 250, 14, 71, 39, 138, 217, 190, 240, 102, 171, 166, 232, 242, 106, 87, 126, 68, 105, 30, 55, 69, 191, 46, 50, 193, 71, 65, 142, 224, 245, 175, 87, 210, 224, 211, 160, 176, 69, 210, 214, 1, 106, 126, 233, 128, 130, 172, 71, 25, 200, 234, 120, 193, 39, 158, 43, 139, 241, 112, 241, 93, 204, 75, 105, 37, 189, 183, 216, 103, 145, 83, 253, 20, 238, 201, 102, 27, 21, 217, 176, 65, 4, 14, 64, 3, 159, 194, 162, 158, 101, 82, 181, 101, 8, 218, 42, 250, 223, 114, 234, 101, 148, 232, 81, 115, 149, 229, 43, 105, 109, 139, 223, 15, 172, 227, 177, 240, 220, 186, 132, 173, 26, 125, 161, 217, 218, 66, 196, 1, 26, 100, 115, 158, 6, 14, 243, 244, 63, 151, 59, 174, 248, 47, 92, 55, 183, 87, 233, 111, 20, 235, 52, 146, 76, 201, 111, 38, 226, 153, 57, 199, 204, 1, 99, 207, 96, 122, 87, 87, 226, 217, 215, 67, 240, 87, 217, 32, 105, 62, 100, 75, 56, 216, 128, 78, 49, 206, 126, 170, 172, 50, 7, 83, 83, 120, 110, 111, 19, 203, 28, 109, 172, 67, 108, 176, 144, 121, 111, 150, 115, 158, 65, 42, 62, 94, 248, 199, 202, 127, 46, 121, 97, 136, 171, 7, 44, 92, 90, 247, 155, 209, 246, 93, 142, 185, 225, 233, 77, 71, 7, 36, 253, 212, 157, 215, 119, 220, 242, 9, 35, 120, 164, 104, 228, 70, 73, 16, 149, 101, 97, 130, 164, 117, 4, 122, 213, 237, 7, 254, 70, 45, 51, 254, 190, 226, 255, 0, 208, 197, 122, 127, 140, 224, 209, 142, 145, 60, 218, 138, 192, 46, 132, 45, 246, 102, 99, 137, 11, 0, 118, 129, 142, 72, 5, 135, 29, 57, 201, 175, 48, 208, 127, 228, 98, 211, 63, 235, 238, 47, 253, 12, 87, 173, 67, 23, 245, 154, 18, 159, 45, 183, 60, 122, 248, 79, 170, 226, 35, 14, 107, 237, 253, 51, 208, 190, 37, 127, 200, 187, 111, 255, 0, 95, 107, 255, 0, 160, 61, 20, 124, 74, 255, 0, 145, 118, 223, 254, 190, 215, 255, 0, 64, 122, 43, 60, 163, 253, 217, 122, 179, 92, 227, 253, 233, 250, 35, 71, 254, 105, 215, 253, 194, 127, 246, 149, 120, 229, 123, 77, 165, 179, 222, 248, 30, 11, 88, 202, 137, 39, 211, 86, 53, 45, 208, 19, 30, 6, 127, 58, 226, 63, 225, 90, 235, 63, 243, 243, 97, 255, 0, 127, 31, 255, 0, 137, 174, 76, 187, 19, 74, 147, 168, 170, 74, 218, 157, 121, 150, 26, 181, 101, 77, 211, 141, 244, 57, 157, 59, 86, 191, 210, 102, 50, 216, 221, 73, 3, 31, 188, 20, 229, 91, 175, 80, 120, 61, 79, 81, 94, 129, 225, 95, 21, 95, 120, 130, 234, 61, 62, 238, 218, 217, 204, 67, 206, 150, 98, 15, 204, 171, 140, 97, 122, 110, 222, 84, 231, 129, 232, 58, 86, 47, 252, 43, 93, 103, 254, 126, 108, 63, 239, 227, 255, 0, 241, 53, 36, 31, 15, 117, 251, 89, 150, 107, 123, 251, 72, 101, 95, 186, 241, 205, 34, 176, 237, 193, 11, 91, 226, 170, 96, 171, 197, 251, 203, 155, 163, 57, 240, 180, 241, 212, 36, 189, 215, 203, 213, 13, 248, 145, 168, 11, 141, 102, 11, 20, 42, 86, 214, 60, 183, 7, 33, 223, 4, 143, 126, 2, 158, 61, 77, 71, 127, 241, 23, 86, 185, 142, 53, 181, 72, 173, 24, 1, 189, 213, 119, 150, 110, 115, 141, 220, 0, 125, 48, 79, 29, 106, 105, 254, 30, 235, 247, 83, 52, 215, 23, 246, 147, 74, 223, 121, 228, 154, 70, 99, 219, 146, 86, 163, 255, 0, 133, 107, 172, 255, 0, 207, 205, 135, 253, 252, 127, 254, 38, 149, 57, 96, 85, 56, 66, 114, 79, 151, 245, 220, 117, 35, 143, 117, 103, 56, 69, 174, 111, 211, 99, 145, 158, 226, 107, 169, 154, 107, 137, 164, 154, 86, 251, 207, 35, 22, 99, 219, 146, 106, 230, 131, 255, 0, 35, 22, 153, 255, 0, 95, 113, 127, 232, 98, 186, 47, 248, 86, 186, 207, 252, 252, 216, 127, 223, 199, 255, 0, 226, 106, 214, 153, 240, 255, 0, 86, 178, 213, 172, 238, 164, 184, 178, 49, 193, 58, 72, 193, 93, 178, 64, 96, 78, 62, 94, 188, 87, 77, 76, 118, 27, 217, 180, 166, 182, 57, 169, 224, 49, 94, 209, 73, 193, 238, 107, 124, 74, 255, 0, 145, 118, 223, 254, 190, 215, 255, 0, 64, 122, 40, 248, 149, 255, 0, 34, 237, 191, 253, 125, 175, 254, 128, 244, 86, 121, 71, 251, 178, 245, 102, 185, 199, 251, 211, 244, 71, 45, 97, 227, 237, 94, 194, 194, 11, 68, 138, 210, 68, 133, 2, 43, 73, 27, 110, 192, 232, 14, 24, 14, 7, 29, 59, 85, 159, 248, 89, 90, 207, 252, 251, 88, 127, 223, 183, 255, 0, 226, 171, 141, 171, 22, 17, 67, 62, 163, 107, 13, 204, 158, 92, 18, 76, 139, 35, 238, 3, 106, 146, 1, 57, 60, 12, 10, 222, 120, 44, 54, 178, 112, 71, 52, 49, 216, 157, 34, 166, 206, 171, 254, 22, 86, 179, 255, 0, 62, 214, 31, 247, 237, 255, 0, 248, 170, 236, 252, 35, 174, 92, 235, 250, 76, 183, 87, 73, 18, 72, 147, 152, 192, 136, 16, 48, 21, 79, 114, 121, 230, 155, 255, 0, 8, 63, 135, 63, 232, 29, 255, 0, 145, 228, 255, 0, 226, 171, 87, 77, 210, 172, 180, 123, 102, 183, 176, 135, 201, 137, 156, 185, 93, 236, 223, 54, 0, 207, 36, 250, 10, 240, 49, 85, 240, 115, 167, 106, 48, 179, 254, 188, 207, 162, 194, 97, 241, 144, 169, 205, 90, 119, 95, 215, 145, 114, 184, 191, 23, 120, 186, 255, 0, 64, 213, 162, 181, 181, 134, 217, 227, 120, 4, 132, 202, 172, 78, 75, 48, 236, 195, 210, 187, 74, 202, 212, 188, 57, 164, 235, 23, 43, 113, 127, 105, 231, 74, 168, 16, 55, 152, 235, 242, 228, 156, 112, 71, 169, 174, 76, 44, 233, 66, 165, 235, 43, 163, 175, 23, 78, 180, 233, 242, 209, 118, 103, 5, 255, 0, 11, 43, 89, 255, 0, 159, 107, 15, 251, 246, 255, 0, 252, 85, 31, 240, 178, 181, 159, 249, 246, 176, 255, 0, 191, 111, 255, 0, 197, 87, 65, 174, 248, 63, 195, 246, 122, 21, 237, 204, 118, 223, 103, 146, 40, 89, 146, 79, 61, 190, 240, 232, 62, 98, 71, 39, 3, 241, 227, 154, 242, 218, 250, 28, 45, 44, 30, 38, 46, 80, 167, 183, 115, 231, 113, 117, 113, 184, 89, 40, 206, 166, 253, 191, 225, 141, 221, 115, 197, 154, 142, 191, 109, 21, 189, 210, 193, 28, 81, 190, 253, 177, 33, 25, 56, 192, 39, 36, 244, 201, 252, 232, 172, 42, 43, 210, 167, 78, 20, 227, 203, 5, 100, 121, 149, 42, 206, 172, 185, 166, 238, 194, 138, 40, 171, 51, 47, 71, 173, 234, 209, 70, 177, 199, 169, 222, 164, 104, 2, 170, 173, 195, 0, 160, 116, 0, 102, 157, 253, 189, 172, 255, 0, 208, 90, 255, 0, 255, 0, 2, 95, 252, 104, 162, 179, 246, 84, 255, 0, 149, 125, 198, 158, 214, 167, 243, 63, 188, 63, 183, 181, 159, 250, 11, 95, 255, 0, 224, 75, 255, 0, 141, 31, 219, 218, 207, 253, 5, 175, 255, 0, 240, 37, 255, 0, 198, 138, 40, 246, 84, 255, 0, 149, 125, 193, 237, 170, 127, 51, 251, 200, 110, 117, 59, 251, 216, 196, 119, 87, 215, 51, 198, 14, 224, 178, 202, 204, 1, 245, 193, 61, 121, 170, 180, 81, 86, 162, 162, 172, 145, 18, 147, 147, 187, 97, 69, 20, 83, 17, 255, 217 };
            //byte[] imgSliders = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 96, 0, 96, 0, 0, 255, 225, 0, 88, 69, 120, 105, 102, 0, 0, 77, 77, 0, 42, 0, 0, 0, 8, 0, 4, 1, 49, 0, 2, 0, 0, 0, 17, 0, 0, 0, 62, 81, 16, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 81, 17, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 81, 18, 0, 4, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 65, 100, 111, 98, 101, 32, 73, 109, 97, 103, 101, 82, 101, 97, 100, 121, 0, 0, 255, 219, 0, 67, 0, 8, 6, 6, 7, 6, 5, 8, 7, 7, 7, 9, 9, 8, 10, 12, 20, 13, 12, 11, 11, 12, 25, 18, 19, 15, 20, 29, 26, 31, 30, 29, 26, 28, 28, 32, 36, 46, 39, 32, 34, 44, 35, 28, 28, 40, 55, 41, 44, 48, 49, 52, 52, 52, 31, 39, 57, 61, 56, 50, 60, 46, 51, 52, 50, 255, 219, 0, 67, 1, 9, 9, 9, 12, 11, 12, 24, 13, 13, 24, 50, 33, 28, 33, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 255, 192, 0, 17, 8, 0, 70, 0, 70, 3, 1, 34, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 31, 0, 0, 1, 5, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 16, 0, 2, 1, 3, 3, 2, 4, 3, 5, 5, 4, 4, 0, 0, 1, 125, 1, 2, 3, 0, 4, 17, 5, 18, 33, 49, 65, 6, 19, 81, 97, 7, 34, 113, 20, 50, 129, 145, 161, 8, 35, 66, 177, 193, 21, 82, 209, 240, 36, 51, 98, 114, 130, 9, 10, 22, 23, 24, 25, 26, 37, 38, 39, 40, 41, 42, 52, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 196, 0, 31, 1, 0, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 255, 196, 0, 181, 17, 0, 2, 1, 2, 4, 4, 3, 4, 7, 5, 4, 4, 0, 1, 2, 119, 0, 1, 2, 3, 17, 4, 5, 33, 49, 6, 18, 65, 81, 7, 97, 113, 19, 34, 50, 129, 8, 20, 66, 145, 161, 177, 193, 9, 35, 51, 82, 240, 21, 98, 114, 209, 10, 22, 36, 52, 225, 37, 241, 23, 24, 25, 26, 38, 39, 40, 41, 42, 53, 54, 55, 56, 57, 58, 67, 68, 69, 70, 71, 72, 73, 74, 83, 84, 85, 86, 87, 88, 89, 90, 99, 100, 101, 102, 103, 104, 105, 106, 115, 116, 117, 118, 119, 120, 121, 122, 130, 131, 132, 133, 134, 135, 136, 137, 138, 146, 147, 148, 149, 150, 151, 152, 153, 154, 162, 163, 164, 165, 166, 167, 168, 169, 170, 178, 179, 180, 181, 182, 183, 184, 185, 186, 194, 195, 196, 197, 198, 199, 200, 201, 202, 210, 211, 212, 213, 214, 215, 216, 217, 218, 226, 227, 228, 229, 230, 231, 232, 233, 234, 242, 243, 244, 245, 246, 247, 248, 249, 250, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 249, 254, 138, 181, 166, 233, 243, 234, 186, 140, 54, 54, 193, 76, 210, 156, 13, 199, 0, 96, 100, 147, 244, 0, 154, 234, 63, 225, 90, 235, 63, 243, 243, 97, 255, 0, 127, 31, 255, 0, 137, 172, 42, 226, 104, 210, 118, 169, 43, 51, 122, 88, 90, 213, 151, 53, 56, 221, 28, 109, 21, 235, 58, 62, 147, 103, 224, 173, 10, 123, 251, 253, 173, 114, 7, 239, 165, 143, 45, 198, 236, 42, 174, 64, 198, 120, 252, 122, 156, 1, 137, 52, 253, 67, 77, 241, 222, 141, 113, 111, 113, 108, 209, 178, 17, 190, 60, 228, 198, 78, 118, 178, 182, 58, 240, 123, 122, 130, 49, 215, 134, 89, 166, 174, 81, 131, 112, 78, 215, 255, 0, 128, 122, 17, 202, 174, 148, 101, 52, 166, 213, 212, 127, 224, 158, 69, 69, 118, 95, 240, 173, 117, 159, 249, 249, 176, 255, 0, 191, 143, 255, 0, 196, 209, 255, 0, 10, 215, 89, 255, 0, 159, 155, 15, 251, 248, 255, 0, 252, 77, 116, 253, 127, 13, 252, 232, 228, 254, 207, 197, 127, 35, 56, 218, 43, 178, 255, 0, 133, 107, 172, 255, 0, 207, 205, 135, 253, 252, 127, 254, 38, 155, 39, 195, 141, 105, 35, 102, 89, 172, 164, 101, 4, 132, 89, 27, 45, 236, 50, 160, 103, 234, 105, 253, 127, 13, 252, 232, 63, 179, 241, 95, 200, 206, 62, 138, 40, 174, 179, 140, 146, 11, 137, 173, 102, 89, 173, 230, 146, 25, 87, 238, 188, 108, 85, 135, 110, 8, 173, 223, 248, 78, 60, 71, 255, 0, 65, 31, 252, 129, 31, 255, 0, 19, 92, 245, 21, 156, 232, 211, 168, 239, 56, 167, 234, 141, 105, 214, 171, 77, 90, 18, 107, 209, 158, 149, 161, 120, 179, 78, 214, 116, 166, 211, 60, 65, 44, 126, 115, 229, 89, 230, 1, 82, 85, 228, 131, 144, 0, 82, 58, 118, 232, 8, 57, 233, 118, 109, 111, 195, 190, 22, 210, 38, 143, 73, 158, 7, 145, 247, 60, 80, 197, 33, 152, 25, 48, 6, 88, 228, 224, 116, 238, 56, 7, 28, 215, 148, 81, 92, 18, 202, 233, 57, 93, 54, 162, 221, 237, 208, 239, 142, 107, 85, 66, 205, 39, 36, 173, 205, 212, 232, 127, 225, 56, 241, 31, 253, 4, 127, 242, 4, 127, 252, 77, 31, 240, 156, 120, 143, 254, 130, 63, 249, 2, 63, 254, 38, 161, 240, 223, 134, 231, 241, 29, 212, 145, 199, 42, 195, 12, 32, 25, 101, 35, 118, 51, 156, 0, 50, 50, 78, 15, 229, 244, 7, 171, 186, 248, 101, 9, 182, 79, 178, 106, 50, 9, 213, 14, 239, 53, 1, 87, 108, 113, 140, 114, 163, 57, 254, 247, 95, 110, 74, 213, 48, 20, 103, 201, 56, 171, 250, 127, 192, 10, 52, 243, 10, 208, 246, 144, 148, 173, 254, 47, 248, 39, 53, 255, 0, 9, 199, 136, 255, 0, 232, 35, 255, 0, 144, 35, 255, 0, 226, 106, 57, 252, 101, 226, 11, 136, 90, 39, 212, 164, 10, 221, 76, 104, 168, 223, 129, 80, 8, 252, 235, 26, 226, 9, 45, 110, 101, 183, 153, 118, 203, 19, 148, 117, 206, 112, 65, 193, 28, 84, 117, 214, 176, 216, 125, 212, 23, 220, 142, 55, 138, 196, 108, 230, 254, 246, 20, 81, 69, 116, 28, 229, 205, 38, 226, 214, 211, 85, 182, 158, 250, 219, 237, 54, 200, 249, 146, 47, 81, 253, 113, 215, 7, 131, 140, 30, 181, 219, 127, 194, 87, 224, 239, 250, 0, 127, 228, 156, 63, 227, 94, 123, 69, 115, 87, 194, 194, 179, 230, 147, 127, 38, 117, 80, 197, 206, 140, 92, 98, 151, 205, 92, 244, 47, 248, 74, 252, 29, 255, 0, 64, 15, 252, 147, 135, 252, 104, 255, 0, 132, 175, 193, 223, 244, 0, 255, 0, 201, 56, 127, 198, 184, 24, 45, 230, 186, 153, 97, 183, 134, 73, 165, 111, 186, 145, 169, 102, 61, 248, 2, 164, 186, 176, 188, 177, 217, 246, 187, 73, 237, 247, 231, 111, 155, 25, 77, 216, 235, 140, 245, 234, 43, 159, 251, 62, 133, 237, 204, 239, 234, 116, 127, 104, 87, 183, 55, 42, 183, 161, 235, 254, 25, 213, 244, 141, 82, 218, 117, 210, 109, 126, 202, 177, 56, 50, 69, 229, 44, 124, 145, 195, 124, 188, 28, 227, 30, 188, 125, 43, 27, 193, 222, 31, 214, 116, 157, 106, 250, 227, 81, 63, 186, 145, 10, 150, 243, 183, 121, 207, 187, 33, 255, 0, 159, 45, 131, 243, 125, 107, 206, 244, 253, 74, 243, 74, 186, 23, 54, 51, 180, 51, 0, 87, 112, 0, 228, 30, 196, 30, 15, 227, 91, 119, 94, 60, 215, 174, 109, 146, 17, 113, 28, 56, 66, 174, 241, 70, 3, 62, 70, 50, 73, 206, 15, 251, 184, 235, 244, 174, 90, 153, 117, 104, 185, 198, 139, 92, 178, 181, 239, 186, 177, 215, 79, 50, 163, 53, 9, 214, 79, 154, 23, 181, 182, 119, 254, 191, 173, 142, 167, 86, 241, 63, 133, 162, 213, 110, 98, 187, 210, 190, 213, 113, 27, 236, 146, 95, 178, 198, 217, 97, 193, 25, 98, 9, 198, 49, 248, 86, 125, 199, 138, 124, 32, 246, 210, 162, 248, 123, 44, 200, 64, 31, 102, 141, 50, 113, 253, 224, 114, 191, 81, 200, 174, 6, 138, 234, 134, 91, 74, 41, 43, 189, 60, 206, 57, 230, 117, 100, 219, 178, 215, 201, 5, 20, 81, 94, 137, 231, 23, 52, 173, 54, 109, 99, 82, 134, 194, 221, 163, 89, 101, 206, 211, 33, 33, 120, 4, 243, 128, 125, 43, 182, 255, 0, 133, 95, 255, 0, 81, 143, 252, 150, 255, 0, 236, 235, 207, 227, 145, 226, 145, 100, 141, 217, 36, 66, 25, 89, 78, 10, 145, 208, 131, 235, 87, 191, 183, 181, 159, 250, 11, 95, 255, 0, 224, 75, 255, 0, 141, 114, 98, 41, 226, 103, 36, 232, 207, 149, 122, 29, 152, 106, 152, 104, 69, 170, 208, 114, 126, 182, 61, 62, 222, 206, 215, 192, 222, 24, 184, 156, 39, 218, 36, 79, 154, 73, 21, 118, 180, 172, 91, 10, 14, 73, 192, 25, 3, 243, 56, 201, 163, 71, 214, 45, 124, 105, 164, 95, 91, 79, 109, 228, 255, 0, 203, 57, 35, 221, 188, 133, 35, 229, 96, 74, 227, 57, 7, 30, 133, 115, 88, 30, 24, 241, 173, 168, 211, 159, 79, 215, 164, 102, 80, 14, 39, 144, 52, 190, 106, 147, 202, 183, 83, 158, 126, 152, 227, 140, 115, 114, 79, 23, 120, 119, 66, 209, 154, 13, 5, 86, 73, 50, 118, 69, 177, 192, 220, 127, 137, 139, 12, 156, 125, 115, 208, 112, 57, 30, 29, 76, 53, 110, 105, 41, 65, 186, 151, 210, 93, 63, 203, 250, 242, 61, 218, 120, 170, 60, 177, 113, 154, 84, 210, 214, 61, 127, 207, 250, 243, 42, 255, 0, 194, 175, 255, 0, 168, 199, 254, 75, 127, 246, 116, 127, 194, 175, 255, 0, 168, 199, 254, 75, 127, 246, 117, 198, 255, 0, 111, 107, 63, 244, 22, 191, 255, 0, 192, 151, 255, 0, 26, 63, 183, 181, 159, 250, 11, 95, 255, 0, 224, 75, 255, 0, 141, 122, 158, 195, 31, 255, 0, 63, 87, 220, 191, 200, 242, 254, 177, 128, 255, 0, 159, 79, 239, 127, 230, 118, 95, 240, 171, 255, 0, 234, 49, 255, 0, 146, 223, 253, 157, 71, 63, 195, 25, 150, 22, 54, 250, 164, 114, 75, 252, 43, 36, 37, 20, 253, 72, 39, 31, 149, 114, 63, 219, 218, 207, 253, 5, 175, 255, 0, 240, 37, 255, 0, 198, 155, 38, 183, 171, 75, 27, 71, 38, 167, 122, 241, 184, 42, 202, 215, 12, 67, 3, 212, 17, 154, 21, 12, 117, 245, 170, 190, 228, 39, 95, 1, 109, 41, 63, 189, 255, 0, 153, 70, 138, 40, 175, 76, 242, 194, 138, 40, 160, 2, 138, 40, 160, 2, 138, 40, 160, 2, 138, 40, 160, 2, 138, 40, 160, 15, 255, 217 };


            con.Insert(new Service(1, "Website", "Bent u opzoek naar een effectieve website die uw doelgroep volledig informeert en op een positieve manier aantrekt? Of uw website nu uit enkele pagina’s bestaat of complexer van aard is, WebSentiment ontwikkelt graag een succesvolle website voor u.", imgEmpty));
            con.Insert(new Service(2, "E-commerce", "Het aantal online verkopen heeft zich de afgelopen jaren enorm ontwikkeld. Het aantal mobiele internetshoppers zal de komende jaren alleen maar toenemen. WebSentiment ontwikkelt professionele en efficiënte webshops op maat met een doel- en conversiegericht design.", imgEmpty));
            con.Insert(new Service(3, "Applicaties op maat", "Heeft u genoeg van tijdrovende bedrijfsprocessen en wilt u uw productiviteit vergroten? Steeds meer bedrijven maken gebruik van online software op maat. WebSentiment heeft meer dan 15 jaar ervaring in huis als het gaat om het automatiseren van bedrijfsprocessen.", imgEmpty));
        }
    }
}
