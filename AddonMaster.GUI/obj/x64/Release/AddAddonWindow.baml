   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   AddonMaster.GUI$   AddonMaster.GUI.AddAddonWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  Jcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  -   
�������$��1q�  � WindowState$  Normal=�(   "MahApps.Metro.Controls.MetroWindow   TitleForeground
 ����� � WindowStyle$
 None=�   ShowCloseButton .   � 
ResizeMode$ NoResize=�   ShowMinButton .  
������� � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterOwner=�   WindowTransitionsEnabled . 	   ShowTitleBar	 .  $
��Auto��.��� -   $��Mygrid��$	��150��$	��370��
�������.+��� $��1q�
�������$��
10,65,5,61q�._��� -   $��TxtUrl��|�. 
���iii�$��Center=�$	��353��
�������$��0q�$��Center=�$
��Left=�$��22������ *OutlinePlain+
 �� Mode$
 TwoWay=� �� NotifyOnTargetUpdated . ��  J� IsHitTestVisible .  $6��0https://www.curseforge.com/wow/addons/bartender4��$��Center=�$
��Left=�$��
12,69,0,65q�
�������$	��300������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ TxtUrl�� �� Value  .a���  � y�$ Visible=���  �� *IsKeyboardFocused+$ TxtUrl�� true.a���  � y�$ 	Collapsed=�� -    �Name$	 Pb1��$y�	Collapsed=� � Value$ 0Q�
�����F� J� Opacity$	 0.8Q�$��0q�
������ $
��Left=�$��10��$��	10,91,0,0q�$	��Top=�$	��355��"  FontAwesome.WPF.ImageAwesome  -   $��
BtnInstall�� � Cursor$
 Hand��{�.  $	 0.6Q�   Icon$ Download=�$��335,119,6,5q�   
Foreground
 ���F��� $��Choose URL:��
���iii�$
��Left=�$��6,42,0,0q�$	��Top=�$��81���� $��80,46,62,88q�$ 1Q��� -   
�����F�$+��%https://www.curseforge.com/wow/addons?�.�'%https://www.curseforge.com/wow/addons�� -   $��	LblStatus��$y�Hidden=�$��Please enter valid URL��
���\\��$
��Left=�$��204,124,0,0q�$	��Top=�$	��127��  -   $��Spinner��$	 Cog=�   Spin . $y�	Collapsed=�
 �iii�$	 0.8Q�   SpinDuration$ 2Q�$��305,119,39,5q�  -	   $ TimesCircle=� � ToolTip$ Close��$
 Hand��$��345,5,5,125q�
 �����  -
   $ MinusCircle=�$ Minimize��$
 Hand��$��320,5,30,125q�
 �����  -   $ QuestionCircle=�$
 Help��$
 Hand��$��295,5,55,125q�
 ������� $��
0,29,0,119q�
�������$��0,1,0,0q��� $��Addon Master��
���iii�$
��Bold"�$
��Left=�$��0,5,0,0q�$	��Top=�