   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    AddonMaster.GUI    AddonMaster.GUI.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5        
�������$��1q�5	      
�������(   "MahApps.Metro.Controls.MetroWindow    TitleForeground
  ����� � 
ResizeMode$ CanMinimize=�5   @      ShowMinButton .     ShowCloseButton .   � SizeToContent$ WidthAndHeight=�6�      ShowTitleBar .     ShowMaxRestoreButton .   � WindowStartupLocation$ CenterScreen=�6�   .��5      � $	��500��6   $	��400��6   
�������.+�5   
   �� -   5        $��lbAddonList��5      $��Stretch=�6%   $��	0,36,0,41q�6J   
�������$��0,1,0,1q�6t   
������ ��5      �� 5      .R�5      � $	��0,2q�6   
������� J� Opacity$ 1Q�6@   	 � ColumnDefinitions	 5      �� 5      $��30 �6/   �� 5      $��10 �6/   �� 5      $��* �6/   �� 5      $��50 �6/   �� 5      $��30 �6/   �� 5      $��2 �6/   �� 5      $��30 �6/   .+�5      �� $��30��6    $��0��6,   ��6<   �� *Image+
 � ToolTip
 6U   �� *Description+6w   �� 5      $��1��6    62   �� 5      $��Center=�6$   
���   �$��2��6R   ��6b   �� *Name+�� 5      $��Center=�6$   $��3��6?   ��6O   �� *Patch+"  FontAwesome.WPF.ImageAwesome  5      $��	imgUpdate��69   -   5           Icon$ Refresh=�5   *   $
 Update addon��6J   $��4��6a   $	 0.9Q�6q      
Foreground
 ���F� � Cursor$
 Hand��6�   $��22��6�   6�   �� 5      $��5��6    62     5       $��	imgRemove��6=   -   5        $ MinusCircle=�5    *   $
 Remove addon��6N   $��6��6e   
 �\\��$
 Hand��6�   $��24��6�   6�   5!      5"      5$        5%   
   -   5        $��imgAdd��5%   U   $ 
PlusCircle=�6   $
 Install an addon��6,   $
 Hand��6G   $��364,464,5,5q�6�   
 ���F�6�   �� 5&   
   -   5        $��lblEmptyList��5&   4   $��Center=�6   $-��'Use the blue button to install an addon��6H   
���iii�$��20(�6�   $��13,200,8,262q�6�     5'   
   -   5        $��Spinner��5'   %   $	 Cog=�6   $y�	Collapsed=�64   
 �����   Spin .    SpinDuration$ 2Q�6n   $��324,466,35,5q�6   6�     5(   
   -   5        $	 Bug=�5(      $#
 Report a bug or give feedback��6%   $
 Hand��6M   $��5,464,364,5q�6{   
 ���p�6�     5)   
   -	   5        $ TimesCircle=�5)      $
 Close��6-   $ 1Q�6=   $
 Hand��6I   $��369,5,5,469q�6z   
 �����6�     5*   
   -
   5        $ MinusCircle=�5*      $
 Minimize��6-   $ 1Q�6@   $
 Hand��6L   $��338,5,36,469q�6}   
 ����� J� RenderTransformOrigin$ 	1.66,0.85&�6�     5+   
   -   5        $ QuestionCircle=�5+      $

 Help��60   $ 1Q�6?   $
 Hand��6K   $��307,5,67,469q�6|   
 �����6�   5,      5-      