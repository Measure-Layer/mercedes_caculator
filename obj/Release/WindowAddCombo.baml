   M S B A M L   `   `   `  ���� C  ?MapleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MapleWPFMapleWPF      MapleWPF.WindowAddCombo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:MapleWPF     -     � 
ResizeMode$  NoResize=� � Title$ 添加Combo��$	��400��$	��750�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName   
KalingRed1  
KalingRed2��%  '��       7   7  �� " ��.���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver
 . . ��� $ border��8    � ��P� 	 � ��
 . . ��� $ border��8   � ��.���   
KalingRed0#��[  � RowDefinitions �� $
��auto ��� $
��auto ��� �� $
��auto �.+��� $��Center=�$��0�� �� Orientation$ Vertical=�.+��� $
��auto��$ 
Horizontal=�$��0��.+��� $��10 10q�$ 
Horizontal=�.+��� -    ��Name$ weImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/we.png���� $��5 0 0 0q�._��� $��we��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ srImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/sr.png���� $��5 0 0 0q�._��� $��sr��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ ltImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/lt.png���� $��5 0 0 0q�._��� $��lt��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ ssImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/ss.png���� $��5 0 0 0q�._��� $��ss��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ gdImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/gd.png���� $��5 0 0 0q�._��� $��gd��$��Consolas)�$��Center=�$��Center=�$��20(��� $ 
Horizontal=�.+��� $��10 10q�$ 
Horizontal=�.+��� -   $ usImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/us.png���� $��5 0 0 0q�._��� $��us��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ rrImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/rr.png���� $��5 0 0 0q�._��� $��rr��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -	   $ abImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/ab.png���� $��5 0 0 0q�._��� $��ab��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -
   $ rmImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/rm.png���� $��5 0 0 0q�._��� $��rm��$��Consolas)�$��Center=�$��Center=�$��20(��� $��10 10q�$ 
Horizontal=�.+��� -   $ leImg��$
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/le.png���� $��5 0 0 0q�._��� $��le��$��Consolas)�$��Center=�$��Center=�$��20(�� $��1�� �� �� .+��� $��0��$��0 30 0 5q�._��� $T��N输入连招次序，以单个字符分隔，留空则为伊师塔，举例：��$��20(�$��Center=�$��Center=�� $��1��$��0 5 0 30q�.+��� $��Center=�$ 
Horizontal=�.+��� $��Center=�._��� $��we ss us ss sr lt gd; => ��$��20(�$��Consolas)�$��Center=�$��Center=��� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/we.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/ss.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/us.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/ss.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/sr.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/lt.png���� $
��None=�$=��7pack://application:,,,/MapleWPF;component/Images/gd.png���� $��2��._��� $ 
Horizontal=�$��Center=�$��10q�.+��� $��Center=�$��Center=�._��� $��	输入：��$��20(��� -    ��Name$ inputTextBox��$��2��$��20(�$��Consolas)�$��Center=�$��5q�$	��500���� $��3��$ 
Horizontal=�$��Right=�.+��� -    ��Name$ okButton��$��确定��$��20(�  
KalingRed3#��[ $��10q�$	��100���� -   $ cancelButton��$��取消��$��20(�#��[ $��10q�$	��100��