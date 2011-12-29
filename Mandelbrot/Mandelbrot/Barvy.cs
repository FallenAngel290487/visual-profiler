﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;

namespace Mandelbrot
{
    class Barvy
    {
       public static Color[] barvy = {Color.FromArgb(25,25,112),
Color.FromArgb(0,0,128),
Color.FromArgb(0,0,128),
Color.FromArgb(0,0,128),
Color.FromArgb(0,0,128),
Color.FromArgb(100,149,237),
Color.FromArgb(100,149,237),
Color.FromArgb(72,61,139),
Color.FromArgb(72,61,139),
Color.FromArgb(106,90,205),
Color.FromArgb(106,90,205),
Color.FromArgb(123,104,238),
Color.FromArgb(123,104,238),
Color.FromArgb(132,112,255),
Color.FromArgb(132,112,255),
Color.FromArgb(0,0,205),
Color.FromArgb(0,0,205),
Color.FromArgb(65,105,225),
Color.FromArgb(65,105,225),
Color.FromArgb(0,0,255),
Color.FromArgb(30,144,255),
Color.FromArgb(30,144,255),
Color.FromArgb(0,191,255),
Color.FromArgb(0,191,255),
Color.FromArgb(135,206,235),
Color.FromArgb(135,206,235),
Color.FromArgb(135,206,250),
Color.FromArgb(135,206,250),
Color.FromArgb(70,130,180),
Color.FromArgb(70,130,180),
Color.FromArgb(176,196,222),
Color.FromArgb(176,196,222),
Color.FromArgb(173,216,230),
Color.FromArgb(173,216,230),
Color.FromArgb(176,224,230),
Color.FromArgb(176,224,230),
Color.FromArgb(175,238,238),
Color.FromArgb(175,238,238),
Color.FromArgb(0,206,209),
Color.FromArgb(0,206,209),
Color.FromArgb(72,209,204),
Color.FromArgb(72,209,204),
Color.FromArgb(64,224,208),
Color.FromArgb(0,255,255),
Color.FromArgb(224,255,255),
Color.FromArgb(224,255,255),
Color.FromArgb(95,158,160),
Color.FromArgb(95,158,160),
Color.FromArgb(102,205,170),
Color.FromArgb(102,205,170),
Color.FromArgb(127,255,212),
Color.FromArgb(0,100,0),
Color.FromArgb(0,100,0),
Color.FromArgb(85,107,47),
Color.FromArgb(85,107,47),
Color.FromArgb(143,188,143),
Color.FromArgb(143,188,143),
Color.FromArgb(46,139,87),
Color.FromArgb(46,139,87),
Color.FromArgb(60,179,113),
Color.FromArgb(60,179,113),
Color.FromArgb(32,178,170),
Color.FromArgb(32,178,170),
Color.FromArgb(152,251,152),
Color.FromArgb(152,251,152),
Color.FromArgb(0,255,127),
Color.FromArgb(0,255,127),
Color.FromArgb(124,252,0),
Color.FromArgb(124,252,0),
Color.FromArgb(0,255,0),
Color.FromArgb(127,255,0),
Color.FromArgb(0,250,154),
Color.FromArgb(0,250,154),
Color.FromArgb(173,255,47),
Color.FromArgb(173,255,47),
Color.FromArgb(50,205,50),
Color.FromArgb(50,205,50),
Color.FromArgb(154,205,50),
Color.FromArgb(154,205,50),
Color.FromArgb(34,139,34),
Color.FromArgb(34,139,34),
Color.FromArgb(107,142,35),
Color.FromArgb(107,142,35),
Color.FromArgb(189,183,107),
Color.FromArgb(189,183,107),
Color.FromArgb(240,230,140),
Color.FromArgb(238,232,170),
Color.FromArgb(238,232,170),
Color.FromArgb(250,250,210),
Color.FromArgb(250,250,210),
Color.FromArgb(255,255,224),
Color.FromArgb(255,255,224),
Color.FromArgb(255,255,0),
Color.FromArgb(255,215,0),
Color.FromArgb(238,221,130),
Color.FromArgb(238,221,130),
Color.FromArgb(218,165,32),
Color.FromArgb(184,134,11),
Color.FromArgb(184,134,11),
Color.FromArgb(188,143,143),
Color.FromArgb(188,143,143),
Color.FromArgb(205,92,92),
Color.FromArgb(205,92,92),
Color.FromArgb(139,69,19),
Color.FromArgb(139,69,19),
Color.FromArgb(160,82,45),
Color.FromArgb(205,133,63),
Color.FromArgb(222,184,135),
Color.FromArgb(245,245,220),
Color.FromArgb(245,222,179),
Color.FromArgb(244,164,96),
Color.FromArgb(244,164,96),
Color.FromArgb(210,180,140),
Color.FromArgb(210,105,30),
Color.FromArgb(178,34,34),
Color.FromArgb(165,42,42),
Color.FromArgb(233,150,122),
Color.FromArgb(233,150,122),
Color.FromArgb(250,128,114),
Color.FromArgb(255,160,122),
Color.FromArgb(255,160,122),
Color.FromArgb(255,165,0),
Color.FromArgb(255,140,0),
Color.FromArgb(255,140,0),
Color.FromArgb(255,127,80),
Color.FromArgb(240,128,128),
Color.FromArgb(240,128,128),
Color.FromArgb(255,99,71),
Color.FromArgb(255,69,0),
Color.FromArgb(255,69,0),
Color.FromArgb(255,0,0),
Color.FromArgb(255,105,180),
Color.FromArgb(255,105,180),
Color.FromArgb(255,20,147),
Color.FromArgb(255,20,147),
Color.FromArgb(255,192,203),
Color.FromArgb(255,182,193),
Color.FromArgb(255,182,193),
Color.FromArgb(219,112,147),
Color.FromArgb(219,112,147),
Color.FromArgb(176,48,96),
Color.FromArgb(199,21,133),
Color.FromArgb(199,21,133),
Color.FromArgb(208,32,144),
Color.FromArgb(208,32,144),
Color.FromArgb(255,0,255),
Color.FromArgb(238,130,238),
Color.FromArgb(221,160,221),
Color.FromArgb(218,112,214),
Color.FromArgb(186,85,211),
Color.FromArgb(186,85,211),
Color.FromArgb(153,50,204),
Color.FromArgb(153,50,204),
Color.FromArgb(148,0,211),
Color.FromArgb(148,0,211),
Color.FromArgb(138,43,226),
Color.FromArgb(138,43,226),
Color.FromArgb(160,32,240),
Color.FromArgb(147,112,219),
Color.FromArgb(147,112,219),
Color.FromArgb(216,191,216),
Color.FromArgb(255,250,250),
Color.FromArgb(238,233,233),
Color.FromArgb(205,201,201),
Color.FromArgb(139,137,137),
Color.FromArgb(255,245,238),
Color.FromArgb(238,229,222),
Color.FromArgb(205,197,191),
Color.FromArgb(139,134,130),
Color.FromArgb(255,239,219),
Color.FromArgb(238,223,204),
Color.FromArgb(205,192,176),
Color.FromArgb(139,131,120),
Color.FromArgb(255,228,196),
Color.FromArgb(238,213,183),
Color.FromArgb(205,183,158),
Color.FromArgb(139,125,107),
Color.FromArgb(255,218,185),
Color.FromArgb(238,203,173),
Color.FromArgb(205,175,149),
Color.FromArgb(139,119,101),
Color.FromArgb(255,222,173),
Color.FromArgb(238,207,161),
Color.FromArgb(205,179,139),
Color.FromArgb(139,121,94),
Color.FromArgb(255,250,205),
Color.FromArgb(238,233,191),
Color.FromArgb(205,201,165),
Color.FromArgb(139,137,112),
Color.FromArgb(255,248,220),
Color.FromArgb(238,232,205),
Color.FromArgb(205,200,177),
Color.FromArgb(139,136,120),
Color.FromArgb(255,255,240),
Color.FromArgb(238,238,224),
Color.FromArgb(205,205,193),
Color.FromArgb(139,139,131),
Color.FromArgb(240,255,240),
Color.FromArgb(224,238,224),
Color.FromArgb(193,205,193),
Color.FromArgb(131,139,131),
Color.FromArgb(255,240,245),
Color.FromArgb(238,224,229),
Color.FromArgb(205,193,197),
Color.FromArgb(139,131,134),
Color.FromArgb(255,228,225),
Color.FromArgb(238,213,210),
Color.FromArgb(205,183,181),
Color.FromArgb(139,125,123),
Color.FromArgb(240,255,255),
Color.FromArgb(224,238,238),
Color.FromArgb(193,205,205),
Color.FromArgb(131,139,139),
Color.FromArgb(131,111,255),
Color.FromArgb(122,103,238),
Color.FromArgb(105,89,205),
Color.FromArgb(71,60,139),
Color.FromArgb(72,118,255),
Color.FromArgb(67,110,238),
Color.FromArgb(58,95,205),
Color.FromArgb(39,64,139),
Color.FromArgb(0,0,255),
Color.FromArgb(0,0,238),
Color.FromArgb(0,0,205),
Color.FromArgb(0,0,139),
Color.FromArgb(30,144,255),
Color.FromArgb(28,134,238),
Color.FromArgb(24,116,205),
Color.FromArgb(16,78,139),
Color.FromArgb(99,184,255),
Color.FromArgb(92,172,238),
Color.FromArgb(79,148,205),
Color.FromArgb(54,100,139),
Color.FromArgb(0,191,255),
Color.FromArgb(0,178,238),
Color.FromArgb(0,154,205),
Color.FromArgb(0,104,139),
Color.FromArgb(135,206,255),
Color.FromArgb(126,192,238),
Color.FromArgb(108,166,205),
Color.FromArgb(74,112,139),
Color.FromArgb(176,226,255),
Color.FromArgb(164,211,238),
Color.FromArgb(141,182,205),
Color.FromArgb(96,123,139),
Color.FromArgb(198,226,255),
Color.FromArgb(185,211,238),
Color.FromArgb(159,182,205),
Color.FromArgb(108,123,139),
Color.FromArgb(202,225,255),
Color.FromArgb(188,210,238),
Color.FromArgb(162,181,205),
Color.FromArgb(110,123,139),
Color.FromArgb(191,239,255),
Color.FromArgb(178,223,238),
Color.FromArgb(154,192,205),
Color.FromArgb(104,131,139),
Color.FromArgb(224,255,255),
Color.FromArgb(209,238,238),
Color.FromArgb(180,205,205),
Color.FromArgb(122,139,139),
Color.FromArgb(187,255,255),
Color.FromArgb(174,238,238),
Color.FromArgb(150,205,205),
Color.FromArgb(102,139,139),
Color.FromArgb(152,245,255),
Color.FromArgb(142,229,238),
Color.FromArgb(122,197,205),
Color.FromArgb(83,134,139),
Color.FromArgb(0,245,255),
Color.FromArgb(0,229,238),
Color.FromArgb(0,197,205),
Color.FromArgb(0,134,139),
Color.FromArgb(0,255,255),
Color.FromArgb(0,238,238),
Color.FromArgb(0,205,205),
Color.FromArgb(0,139,139),
Color.FromArgb(151,255,255),
Color.FromArgb(141,238,238),
Color.FromArgb(121,205,205),
Color.FromArgb(82,139,139),
Color.FromArgb(127,255,212),
Color.FromArgb(118,238,198),
Color.FromArgb(102,205,170),
Color.FromArgb(69,139,116),
Color.FromArgb(193,255,193),
Color.FromArgb(180,238,180),
Color.FromArgb(155,205,155),
Color.FromArgb(105,139,105),
Color.FromArgb(84,255,159),
Color.FromArgb(78,238,148),
Color.FromArgb(67,205,128),
Color.FromArgb(46,139,87),
Color.FromArgb(154,255,154),
Color.FromArgb(144,238,144),
Color.FromArgb(124,205,124),
Color.FromArgb(84,139,84),
Color.FromArgb(0,255,127),
Color.FromArgb(0,238,118),
Color.FromArgb(0,205,102),
Color.FromArgb(0,139,69),
Color.FromArgb(0,255,0),
Color.FromArgb(0,238,0),
Color.FromArgb(0,205,0),
Color.FromArgb(0,139,0),
Color.FromArgb(127,255,0),
Color.FromArgb(118,238,0),
Color.FromArgb(102,205,0),
Color.FromArgb(69,139,0),
Color.FromArgb(192,255,62),
Color.FromArgb(179,238,58),
Color.FromArgb(154,205,50),
Color.FromArgb(105,139,34),
Color.FromArgb(202,255,112),
Color.FromArgb(188,238,104),
Color.FromArgb(162,205,90),
Color.FromArgb(110,139,61),
Color.FromArgb(255,246,143),
Color.FromArgb(238,230,133),
Color.FromArgb(205,198,115),
Color.FromArgb(139,134,78),
Color.FromArgb(255,236,139),
Color.FromArgb(238,220,130),
Color.FromArgb(205,190,112),
Color.FromArgb(139,129,76),
Color.FromArgb(255,255,224),
Color.FromArgb(238,238,209),
Color.FromArgb(205,205,180),
Color.FromArgb(139,139,122),
Color.FromArgb(255,255,0),
Color.FromArgb(238,238,0),
Color.FromArgb(205,205,0),
Color.FromArgb(139,139,0),
Color.FromArgb(255,215,0),
Color.FromArgb(238,201,0),
Color.FromArgb(205,173,0),
Color.FromArgb(139,117,0),
Color.FromArgb(255,193,37),
Color.FromArgb(238,180,34),
Color.FromArgb(205,155,29),
Color.FromArgb(139,105,20),
Color.FromArgb(255,185,15),
Color.FromArgb(238,173,14),
Color.FromArgb(205,149,12),
Color.FromArgb(139,101,8),
Color.FromArgb(255,193,193),
Color.FromArgb(238,180,180),
Color.FromArgb(205,155,155),
Color.FromArgb(139,105,105),
Color.FromArgb(255,106,106),
Color.FromArgb(238,99,99),
Color.FromArgb(205,85,85),
Color.FromArgb(139,58,58),
Color.FromArgb(255,130,71),
Color.FromArgb(238,121,66),
Color.FromArgb(205,104,57),
Color.FromArgb(139,71,38),
Color.FromArgb(255,211,155),
Color.FromArgb(238,197,145),
Color.FromArgb(205,170,125),
Color.FromArgb(139,115,85),
Color.FromArgb(255,231,186),
Color.FromArgb(238,216,174),
Color.FromArgb(205,186,150),
Color.FromArgb(139,126,102),
Color.FromArgb(255,165,79),
Color.FromArgb(238,154,73),
Color.FromArgb(205,133,63),
Color.FromArgb(139,90,43),
Color.FromArgb(255,127,36),
Color.FromArgb(238,118,33),
Color.FromArgb(205,102,29),
Color.FromArgb(139,69,19),
Color.FromArgb(255,48,48),
Color.FromArgb(238,44,44),
Color.FromArgb(205,38,38),
Color.FromArgb(139,26,26),
Color.FromArgb(255,64,64),
Color.FromArgb(238,59,59),
Color.FromArgb(205,51,51),
Color.FromArgb(139,35,35),
Color.FromArgb(255,140,105),
Color.FromArgb(238,130,98),
Color.FromArgb(205,112,84),
Color.FromArgb(139,76,57),
Color.FromArgb(255,160,122),
Color.FromArgb(238,149,114),
Color.FromArgb(205,129,98),
Color.FromArgb(139,87,66),
Color.FromArgb(255,165,0),
Color.FromArgb(238,154,0),
Color.FromArgb(205,133,0),
Color.FromArgb(139,90,0),
Color.FromArgb(255,127,0),
Color.FromArgb(238,118,0),
Color.FromArgb(205,102,0),
Color.FromArgb(139,69,0),
Color.FromArgb(255,114,86),
Color.FromArgb(238,106,80),
Color.FromArgb(205,91,69),
Color.FromArgb(139,62,47),
Color.FromArgb(255,99,71),
Color.FromArgb(238,92,66),
Color.FromArgb(205,79,57),
Color.FromArgb(139,54,38),
Color.FromArgb(255,69,0),
Color.FromArgb(238,64,0),
Color.FromArgb(205,55,0),
Color.FromArgb(139,37,0),
Color.FromArgb(255,0,0),
Color.FromArgb(238,0,0),
Color.FromArgb(205,0,0),
Color.FromArgb(139,0,0),
Color.FromArgb(255,20,147),
Color.FromArgb(238,18,137),
Color.FromArgb(205,16,118),
Color.FromArgb(139,10,80),
Color.FromArgb(255,110,180),
Color.FromArgb(238,106,167),
Color.FromArgb(205,96,144),
Color.FromArgb(139,58,98),
Color.FromArgb(255,181,197),
Color.FromArgb(238,169,184),
Color.FromArgb(205,145,158),
Color.FromArgb(139,99,108),
Color.FromArgb(255,174,185),
Color.FromArgb(238,162,173),
Color.FromArgb(205,140,149),
Color.FromArgb(139,95,101),
Color.FromArgb(255,130,171),
Color.FromArgb(238,121,159),
Color.FromArgb(205,104,137),
Color.FromArgb(139,71,93),
Color.FromArgb(255,52,179),
Color.FromArgb(238,48,167),
Color.FromArgb(205,41,144),
Color.FromArgb(139,28,98),
Color.FromArgb(255,62,150),
Color.FromArgb(238,58,140),
Color.FromArgb(205,50,120),
Color.FromArgb(139,34,82),
Color.FromArgb(255,0,255),
Color.FromArgb(238,0,238),
Color.FromArgb(205,0,205),
Color.FromArgb(139,0,139),
Color.FromArgb(255,131,250),
Color.FromArgb(238,122,233),
Color.FromArgb(205,105,201),
Color.FromArgb(139,71,137),
Color.FromArgb(255,187,255),
Color.FromArgb(238,174,238),
Color.FromArgb(205,150,205),
Color.FromArgb(139,102,139),
Color.FromArgb(224,102,255),
Color.FromArgb(209,95,238),
Color.FromArgb(180,82,205),
Color.FromArgb(122,55,139),
Color.FromArgb(191,62,255),
Color.FromArgb(178,58,238),
Color.FromArgb(154,50,205),
Color.FromArgb(104,34,139),
Color.FromArgb(155,48,255),
Color.FromArgb(145,44,238),
Color.FromArgb(125,38,205),
Color.FromArgb(85,26,139),
Color.FromArgb(171,130,255),
Color.FromArgb(159,121,238),
Color.FromArgb(137,104,205),
Color.FromArgb(93,71,139),
Color.FromArgb(255,225,255),
Color.FromArgb(238,210,238),
Color.FromArgb(205,181,205)};
    }
}
