   M S B A M L   `   `   `  ����C  ?MapleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MapleWPFMapleWPF  5   	       MapleWPF.WindowAddCombo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MapleWPF     5   	   -   5          � 
ResizeMode$  NoResize=�5
   	    � Title$ 添加Combo��5   	   $	��400��6   $	��750��6&    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName   
KalingRed1  
KalingRed2��%�  '��       7   7  �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   �� $ border��6)   8    � ��6S   5      P� 5      	 � ��
 . . �5   "   �� $ border��6)   8   � ��6S   5      5      5      5      5       .��5"      �   
KalingRed0#��[ 6    � RowDefinitions 5#   
   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      �� 5'      $
��auto �6   .+�5)   
   �� $��Center=�6   $��0��62    �� Orientation$ Vertical=�6?   .+�5*      �� $
��auto��6   $ 
Horizontal=�6&   $��0��6?   .+�5+      �� $��10 10q�6   $ 
Horizontal=�6,   .+�5,      �� -   5         ��Name$ weImg��5,      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/we.png��6:   �� 5-      $��5 0 0 0q�6   ._�5.      �� $��we��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5/      50      �� 51      $��10 10q�6   $ 
Horizontal=�6,   .+�52      �� -   5        $ srImg��52      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/sr.png��6:   �� 53      $��5 0 0 0q�6   ._�54      �� $��sr��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   55      56      �� 57      $��10 10q�6   $ 
Horizontal=�6,   .+�58      �� -   5        $ ltImg��58      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/lt.png��6:   �� 59      $��5 0 0 0q�6   ._�5:      �� $��lt��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5;      5<      �� 5=      $��10 10q�6   $ 
Horizontal=�6,   .+�5>      �� -   5        $ ssImg��5>      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6:   �� 5?      $��5 0 0 0q�6   ._�5@      �� $��ss��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5A      5B      �� 5C      $��10 10q�6   $ 
Horizontal=�6,   .+�5D      �� -   5        $ gdImg��5D      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/gd.png��6:   �� 5E      $��5 0 0 0q�6   ._�5F      �� $��gd��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5G      5H      5I      �� 5J      $ 
Horizontal=�6   .+�5K      �� $��10 10q�6   $ 
Horizontal=�6,   .+�5L      �� -   5        $ usImg��5L      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/us.png��6:   �� 5M      $��5 0 0 0q�6   ._�5N      �� $��us��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5O      5P      �� 5Q      $��10 10q�6   $ 
Horizontal=�6,   .+�5R      �� -   5        $ rrImg��5R      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/rr.png��6:   �� 5S      $��5 0 0 0q�6   ._�5T      �� $��rr��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5U      5V      �� 5W      $��10 10q�6   $ 
Horizontal=�6,   .+�5X      �� -	   5        $ abImg��5X      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/ab.png��6:   �� 5Y      $��5 0 0 0q�6   ._�5Z      �� $��ab��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5[      5\      �� 5]      $��10 10q�6   $ 
Horizontal=�6,   .+�5^      �� -
   5        $ rmImg��5^      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/rm.png��6:   �� 5_      $��5 0 0 0q�6   ._�5`      �� $��rm��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5a      5b      �� 5c      $��10 10q�6   $ 
Horizontal=�6,   .+�5d      �� -   5        $ leImg��5d      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/le.png��6:   �� 5e      $��5 0 0 0q�6   ._�5f      �� $��le��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5g      5h      5i      5j      � 5k   
   $��1��6    5l      �� 5m      �� 5n      .+�5p      �� $��0��6   $��0 30 0 5q�6"   ._�5q      �� $T��N输入连招次序，以单个字符分隔，留空则为伊师塔，举例：��6   $��20(�6>   $��Center=�6L   $��Center=�6i   5r      � 5s      $��1��6   $��0 5 0 30q�6    .+�5t      �� $��Center=�6   $ 
Horizontal=�6:   .+�5u      �� $��Center=�6   ._�5v      �� $��we ss us ss sr lt gd; => ��6$   $��20(�6E   $��Consolas)�6S   $��Center=�6i   $��Center=�6�   5w      �� 5x      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/we.png��6+   �� 5y      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6+   �� 5z      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/us.png��6+   �� 5{      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6+   �� 5|      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/sr.png��6+   �� 5}      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/lt.png��6+   �� 5~      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/gd.png��6+   5      5�      5�      �� 5�   
   $��2��6   ._�5�      �� $ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�5�      �� $��Center=�6   $��Center=�66   ._�5�      �� $��	输入：��6    $��20(�6+   5�      �� 5�      -   5         ��Name$ inputTextBox��5�      $��2��60   $��20(�6=   $��Consolas)�6K   $��Center=�6a   $��5q�6|   $	��500��6�   5�      5�      �� 5�   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5�      �� -   5         ��Name$ okButton��5�      $��确定��6'   $��20(�64     
KalingRed3#��[ 6B   $��10q�6k   $	��100��6w   6�   �� 5�      -   5        $ cancelButton��5�      $��取消��6+   $��20(�68   #��[ 6F   $��10q�6o   $	��100��6{   6�   5�      5�      5�      