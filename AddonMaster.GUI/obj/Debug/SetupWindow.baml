   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI!   AddonMaster.GUI.SetupWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5        
�������$��1q�5
      (   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � 
ResizeMode$ NoResize=�5   )   
������� � SizeToContent$ WidthAndHeight=�5   $    � WindowStartupLocation$ CenterScreen=�6C    � WindowStyle$
 None=�6i      ShowTitleBar .     ShowCloseButton .     ShowMinButton .  .��5      � $	��150��6   $	��370��6   
�������.+�5   
   �� $��1q�6   
�������$��
30,59,5,67q�6<   ._�5      �� -   5        $��TxtAddonFolderPath��5   3  
���   � �� 
IsReadOnly . $��Center=�6�   $	��335��6�   
�������$��0q�6�   $��Center=�6�   $
��Left=�6  $��0q�6M  $��24��6X  ��6;   �� *OutlinePlain+	 �� Mode$	 TwoWay=�
 �� NotifyOnTargetUpdated
 . 6X  5      �� 5   
    J� IsHitTestVisible .  $?��9C:\Program Files (x86)\World of Warcraft\Interface\AddOns��6-   $��Center=�6n   $
��Left=�6�   $��
34,63,0,71q�6�   
�������$	��331��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� *Text+ �� ElementName$ TxtAddonFolderPath�� �� Value  6_   .a�5      ��  � y�$ Visible=�6;   5      5      5      "  FontAwesome.WPF.ImageAwesome  5   
   -   5        $��BtnOpenDirectoryDialogue��5   6    � Cursor$
 Hand��6    J� Opacity$	 0.8Q�6(      Icon$ 
FolderOpen=�6�      
Foreground
 ���F�$��3,59,343,67q�6�    J� RenderTransformOrigin$ 0.5,0&�6�   6�     5   
   -   5          Name$ BtnContinue��5   _   {�.  $
 Hand��6,   
 ���F�$	 0.6Q�6Q   $ SignIn=�6�   $��341,126,6,5q�6�   $ 0.5,0&�6�   �� 5    
   -   5        $��	LblStatus��5       $��Please select valid path��6!   $y�	Collapsed=�6D   
���\\��$
��Left=�6r   $��200,123,0,0q�6�   $	��Top=�6�   $	��146��6�     5!   
   -   5        $ TimesCircle=�5!       � ToolTip$ Close��6-   $
 Hand��6=   $��345,5,5,125q�6n   
 �����$ 0.5,0.5&�6�     5"   
   -   5        $ MinusCircle=�5"      $ Minimize��6-   $
 Hand��6@   $��320,5,30,125q�6q   
 �����$ 0.5,0.5&�6�     5#   
   -   5        $ QuestionCircle=�5#      $
 Help��60   $
 Hand��6?   $��295,5,55,125q�6p   
 �����$ 0.5,0.5&�6�   �� 5$   
   
���iii�$+��%Select World of Warcraft addon folder��6%   $
��Left=�6U   $��	28,36,0,0q�6p   $	��Top=�6�   $	��228��6�   $��23��6�   �� 5%   
   $��
0,29,0,119q�6   
�������$��0,1,0,0q�6<   6X   �� 5&   
   $��Addon Master��6   
���iii�$
��Bold"�6<   $
��Left=�6N   $��0,5,0,0q�6i   $	��Top=�6z   5'      5(      