   M S B A M L   `   `   `  ����C  ?MapleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MapleWPFMapleWPF  5   	       MapleWPF.WindowAddCombo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MapleWPF     5   	   -   5          � 
ResizeMode$  NoResize=�5
   	    � Title$ 添加Combo��5   	   $	��400��6   $	��750��6&   .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��Center=�6   $��0��62    �� Orientation$ Vertical=�6?   .+�5      �� $
��auto��6   $ 
Horizontal=�6&   $��0��6?   .+�5      �� $��10 10q�6   $ 
Horizontal=�6,   .+�5      �� -   5         ��Name$ weImg��5      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/we.png��6:   �� 5      $��5 0 0 0q�6   ._�5      �� $��we��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5      5      �� 5      $��10 10q�6   $ 
Horizontal=�6,   .+�5      �� -   5        $ srImg��5      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/sr.png��6:   �� 5      $��5 0 0 0q�6   ._�5      �� $��sr��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5      5       �� 5!      $��10 10q�6   $ 
Horizontal=�6,   .+�5"      �� -   5        $ ltImg��5"      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/lt.png��6:   �� 5#      $��5 0 0 0q�6   ._�5$      �� $��lt��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5%      5&      �� 5'      $��10 10q�6   $ 
Horizontal=�6,   .+�5(      �� -   5        $ ssImg��5(      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6:   �� 5)      $��5 0 0 0q�6   ._�5*      �� $��ss��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5+      5,      �� 5-      $��10 10q�6   $ 
Horizontal=�6,   .+�5.      �� -   5        $ gdImg��5.      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/gd.png��6:   �� 5/      $��5 0 0 0q�6   ._�50      �� $��gd��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   51      52      53      �� 54      $ 
Horizontal=�6   .+�55      �� $��10 10q�6   $ 
Horizontal=�6,   .+�56      �� -   5        $ usImg��56      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/us.png��6:   �� 57      $��5 0 0 0q�6   ._�58      �� $��us��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   59      5:      �� 5;      $��10 10q�6   $ 
Horizontal=�6,   .+�5<      �� -   5        $ rrImg��5<      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/rr.png��6:   �� 5=      $��5 0 0 0q�6   ._�5>      �� $��rr��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5?      5@      �� 5A      $��10 10q�6   $ 
Horizontal=�6,   .+�5B      �� -	   5        $ abImg��5B      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/ab.png��6:   �� 5C      $��5 0 0 0q�6   ._�5D      �� $��ab��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5E      5F      �� 5G      $��10 10q�6   $ 
Horizontal=�6,   .+�5H      �� -
   5        $ rmImg��5H      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/rm.png��6:   �� 5I      $��5 0 0 0q�6   ._�5J      �� $��rm��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5K      5L      �� 5M      $��10 10q�6   $ 
Horizontal=�6,   .+�5N      �� -   5        $ leImg��5N      $
��None=�6+   $=��7pack://application:,,,/MapleWPF;component/Images/le.png��6:   �� 5O      $��5 0 0 0q�6   ._�5P      �� $��le��6$   $��Consolas)�6.   $��Center=�6D   $��Center=�6a   $��20(�6|   5Q      5R      5S      5T      � 5U   
   $��1��6    5V      �� 5W      �� 5X      .+�5Z      �� $��0��6   $��0 30 0 5q�6"   ._�5[      �� $T��N输入连招次序，以单个字符分隔，留空则为伊师塔，举例：��6   $��20(�6>   $��Center=�6L   $��Center=�6i   5\      � 5]      $��1��6   $��0 5 0 30q�6    .+�5^      �� $��Center=�6   $ 
Horizontal=�6:   .+�5_      �� $��Center=�6   ._�5`      �� $��we ss us ss sr lt gd; => ��6$   $��20(�6E   $��Consolas)�6S   $��Center=�6i   $��Center=�6�   5a      �� 5b      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/we.png��6+   �� 5c      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6+   �� 5d      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/us.png��6+   �� 5e      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/ss.png��6+   �� 5f      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/sr.png��6+   �� 5g      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/lt.png��6+   �� 5h      $
��None=�6   $=��7pack://application:,,,/MapleWPF;component/Images/gd.png��6+   5i      5j      5k      �� 5l   
   $��2��6   ._�5m      �� $ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�5n      �� $��Center=�6   $��Center=�66   ._�5o      �� $��	输入：��6    $��20(�6+   5p      �� 5q      -   5         ��Name$ inputTextBox��5q      $��2��60   $��20(�6=   $��Consolas)�6K   $��Center=�6a   $��5q�6|   $	��500��6�   5r      5s      �� 5t   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5u      �� -   5         ��Name$ okButton��5u      $��确定��6'   $��20(�64   
����ح�$��10q�6Y   $	��100��6e   6q   �� 5v      -   5        $ cancelButton��5v      $��取消��6+   $��20(�68   
����ح�$��10q�6]   $	��100��6i   6u   5w      5y      5z      