   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI$   AddonMaster.GUI.AddAddonWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   -   5        
�������$��1q�5
        � WindowState$  Normal=�5      (   "MahApps.Metro.Controls.MetroWindow   TitleForeground
 ����� � WindowStyle$
 None=�6H      ShowCloseButton .   � 
ResizeMode$ NoResize=�5   /      ShowMinButton .  
������� � SizeToContent$ WidthAndHeight=�5       � WindowStartupLocation$ CenterOwner=�66      WindowTransitionsEnabled . 	   ShowTitleBar	 .  $
��Auto��6�   .��5      � -   5        $��mygrid��5      $	��150��6   $	��370��6&   
�������.+�5   
   �� $��1q�6   
�������$��
10,57,5,69q�6<   ._�5      �� -   5        $��txtUrl��5   3  |�. 
���iii�$��Center=�6�   $	��353��6�   
�������$��0q�6�   $��Center=�6�   $
��Left=�6  $��22��6A  ��6'   �� *OutlinePlain+
 �� Mode$
 TwoWay=� �� NotifyOnTargetUpdated . 6A  5      �� 5   
    J� IsHitTestVisible .  $6��0https://www.curseforge.com/wow/addons/bartender4��6-   $��Center=�6e   $
��Left=�6�   $��
12,61,0,73q�6�   
�������$	��300��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 5      �� 5       �� Binding 6&   �� *Text+ �� ElementName$ txtUrl�� �� Value  6S   .a�5      ��  � y�$ Visible=�6;   5      �� 5       6&   �� *IsKeyboardFocused+$ txtUrl�� true6`   .a�5      ��  � y�$ 	Collapsed=�6;   5      5      5       � 5!   
   -   5         �Name$	 pb1��5!   -   $y�	Collapsed=�6    � Value$ 0Q�6:   
�����F� J� Opacity$	 0.8Q�6[   $��0q�6i   
������ $
��Left=�6�   $��10��6�   $��	10,84,0,0q�6�   $	��Top=�6�   $	��355��6�   "  FontAwesome.WPF.ImageAwesome  5"   
   -   5        $��
btnInstall��5"   :    � Cursor$
 Hand��6   {�.  $	 0.6Q�6i      Icon$ Download=�6w   $��335,119,6,5q�6�      
Foreground
 ���F�6�   �� 5#   
   $��Choose URL:��6   
���iii�$
��Left=�6;   $��6,34,0,0q�6V   $	��Top=�6h   $��81��6�   �� 5$   
   $��80,38,62,96q�6   $ 1Q�6)   �� 5%      -   5        
�����F�$+��%https://www.curseforge.com/wow/addons?�5%   3   .�6�   '%https://www.curseforge.com/wow/addons5'      5(      �� 5)   
   -   5        $��	lblStatus��5)   E   $y�Hidden=�6   $��Please enter valid URL��6$   
���\\��$
��Left=�6m   $��204,124,0,0q�6�   $	��Top=�6�   $	��127��6�     5*   
   -   5        $��spinner��5*   %   $	 Cog=�6      Spin . $y�	Collapsed=�6@   
 �iii�$	 0.8Q�6l      SpinDuration$ 2Q�6z   $��305,119,39,5q�6�     5+   
   -	   5        $ TimesCircle=�5+       � ToolTip$ Close��6-   $
 Hand��6=   $��345,5,5,125q�6n   
 �����6�     5,   
   -
   5        $ MinusCircle=�5,      $ Minimize��6-   $
 Hand��6@   $��320,5,30,125q�6q   
 �����6�     5-   
   -   5        $ QuestionCircle=�5-      $
 Help��60   $
 Hand��6?   $��295,5,55,125q�6p   
 �����6�   5.      5/      