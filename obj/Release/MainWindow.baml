   M S B A M L   `   `   `  ���� C  ?MapleWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MapleWPFMapleWPF      MapleWPF.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:MapleWPF       � Title$2  ,MapleStory Mercedes Action Strategy Analysis��$	��900��$
��1600�� � 
ResizeMode$ NoResize=� � 	Resources    BorderColor  KalingRed5Color �� Color �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName  
KalingRed1  
KalingRed2��%  &	        7  '�� 
     7  7  �� 8   �� " ��.���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��._��� $��Center=�$��Center=�	 P� 
 �@J�IsMouseOver . . ��� $ border��8    � ��P� 
 � �� . . ��� $ border��8   � ��.���   
KalingRed0#��[  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0��$��200 20q� � ColumnDefinitions �� �� �� �� �� �� �� �� $
��auto �.+��� $��0�� �� Orientation$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/ir.png��$
��None=��� -    ��Name$ 
M1ComboBox��  
KalingRed3#��[ $��50��$��Center=�$��20(�$��Consolas)��� $��1��$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/we.png��$
��None=��� -   $ 
M2ComboBox��#��[ $��50��$��Center=�$��20(�$��Consolas)��� $��2��$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/ss.png��$
��None=��� -   $ 
M3ComboBox��#��[ $��50��$��Center=�$��20(�$��Consolas)��� $��3��$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/jl.png��$
��None=��� -   $ 
M4ComboBox��#��[ $��50��$��Center=�$��20(�$��Consolas)��� $��4��$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/v1.png��$
��None=��� -   $ 
V1ComboBox��#��[ $��50��$��Center=�$��20(�$��Consolas)��� $��5��$ 
Horizontal=�$��Center=�.+��� $��0 0 20 0q�$��Images/v2.png��$
��None=��� -   $ 
V2ComboBox��#��[ $��50��$��Center=�$��20(�$��Consolas)��� -    ��Name$ SpeedButton��$��6��$��Current Server: CMS��
���  ��$��20(�$��Consolas)��� -   $
 Help��$��7��$
��Help��$��30 0 0 0q��� $��1�� �� Padding$ 10q�$
��auto��$��Center=�._�� $��1�� �� $��60 ��� $��1 ��� .+��� $��0��#��[  $��0 3 0 3q�$ 1 0 0 0q�._��� $ 
Horizontal=�.+��� #��[ $��50��#��[  $��3 0 1 0q�._��� $��序号��$��20(�$��Center=�$��Center=��� #��[ $	��280��#��[  $��0 0 1 0q�._��� $��技能序列��$��20(�$��Center=�$��Center=��� $��50��#��[  $��0 0 1 0q�._��� $��CD��$��20(�$��Center=�$��Center=��� #��[ $��50��#��[  $��0 0 1 0q�._��� $��循环��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��� $��
停顿(ms)��$
��Wrap=�$��20(�$��Center=�$��Center=��� $��75��#��[  $��0 0 1 0q�._��� $��	无后摇��$
��Wrap=�$��20(�$��Center=�$��Center=��� $	��100��#��[  $��0 0 1 0q�._��� $��	伊师塔��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��  �� �� .+��� $��0��$��时长/周期��$��20(�$��Center=�$��Center=��� $��1��$
��(ms)��$��20(�$��Center=�$��Center=��� $��50��#��[  $��0 0 1 0q�._��� $��骑马��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��  �� �� .+��� $��0��$��常态��$��20(�$��Center=�$��Center=��� $��1��$��伤害密度��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��� $��比率��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��  �� �� .+��� $��0��$��V1��$��20(�$��Center=�$��Center=��� $��1��$��伤害密度��$��20(�$��Center=�$��Center=��� #��[ $	��100��#��[  $��0 0 1 0q�._��� $��比率��$��20(�$��Center=�$��Center=��� $��50��#��[  $��0 0 3 0q�._��� $��操作��$��20(�$��Center=�$��Center=��� -	    ��Name$ ComboListBox��$��2��#��[ #��[  $��0 1 0 3q����� " ��.���  � ��$ 0,0,0,1q���  � �� �� " ��.R���   
KalingRed5#��[ $��0,0,0,1q�._��� ���� .R�   MapleWPF.ComboControl  �� -
   $ 	AddButton��$
��1300��$��50��$��Add New Combo��$��20(�#��[ $��2��