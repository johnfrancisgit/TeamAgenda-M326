   M S B A M L   `   `   `  ����H  DM120-LB2-FS16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:M120_LB2_FS16M120_LB2_FS16  5          M120_LB2_FS16.newProject   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:M120_LB2_FS16     5        N� Title$  
newProject��5	      .��5      � 
�������$��15q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� 
�������$��14(�6#   $
��Bold"�61   .��6C   Neue Projekt6Q   �� 5   
   $��1��6   .��6   Name:6$   �� 5   
   -   5         ��Name$ projName��5      $��1��6$   $��1��61   $��5q�6A   �� 5   
   $��2��6   .��6   Gesamt Zeit (Stunden):65   �� 5   
   -   5        $ 
projGesamt��5      $��2��6&   $��1��63   $��5q�6C   �� 5    
   $��3��6   .��6   Offene Zeit (Stunden):65   �� 5!   
   -   5        $ 
projOffene��5!      $��3��6&   $��1��63   $��5q�6C   �� 5"   
   $��4��6   .��6   Start Datum:6+   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ 	projStart��5#      $��4��6(   $��1��65   $��5q�6E   �� 5$   
   $��5��6   .��6   
End Datum:6*     5%   
   -   5        $ projEnd��5%      $��5��6&   $��1��63   $��5q�6C   �� 5&   
   $��6��6   .��6   
Ist Aktiv:6)   �� 5'   
   -   5         ��Name$ 	projAktiv��5'      $��6��6&   $��1��63   $��5q�6C   6P   �� 5(   
   $��1��6   $��7��6%    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��5q�6g   .+�5)      �� -   5         ��Name$ btnID��5)      $y�	Collapsed=�6$   6=   �� 5*      -   5        $ 
projSubmit��5*      
 � Tag$	 new��6A   .��6K   	Speichern6V   5+      �� 5,   
   -	   5        	 ��Name$	 success��5,      $��2��6%   $��8��69   ���	#FF2EFF00$��Center=�6]   $��0,5,0,0q�6z   $��16(�6�   $��Segoe UI Emoji)�6�   6�   5.      5/      