   M S B A M L   `   `   `  ����A  =Lab-10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WPFCustomControlsWPFCustomControls  5   	       Lab_10.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3controlclr-namespace:WPFCustomControls     5   	     � Title$  Notepad��5   	   $	��480��6   $	��800��6&   .��5      �    windowStyle#���   6    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5	      6   �� 5
      $��25 �6   6*    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   o� $��0��6   $��0��6   #���   5      $��25��5      .@�5      m� $
��File��6   .@�5      m� -   5        $	��New��5      6,   m� 5      -   5        $
��Open��5      6,   m� 5      -   5        $��Save As��5      6,   �� 5      m� 5      -   5        $
��Exit��5      6)   5      m� 5      $
��Edit��6   .@�5      m� -   5        $
��Copy��5      6*   m� 5      -   5        $��Paste��5      6*   5      �� 5      �� 5      -   5        ��5   0   Z� ��6F   Z� .��5       �� $��arrow_undo.png��6   5!      �� 5"      -   5        ��5"   0   Z� ��6F   Z� .��5#      �� $��arrow_redo.png��6   5$      �� 5%      �� 5&      -	   5         ��Name$ cmbFontFamily��5&      $��23��5'      $	��150��6#    �� SelectedItem$ Segoe UI��5(      $��Center=�5)        
fontFamily#���  5+      �� 5,      d� 5-      -
   5         d�Name$ btnBold��5-      $��18��6,   $ ��EditingCommands.ToggleBold��5.      .��5/      �� $��Times New Roman)�6   $
��Bold"�69   B6N   50      d� 51      -   5        $ 	btnItalic��51      $��18��6.   $"��EditingCommands.ToggleItalic��52      .��53      �� $��Times New Roman)�6   $��Italic$�69   I6O   54      d� 55      -   5        $ btnUnderline��55      $��18��61   $%��EditingCommands.ToggleUnderline��56      .��57      �� $��Times New Roman)�6   $��	Underline{�69   U6X   58      �� 59      �� 5:      -   5        $ cmbFontSize��5:      $��23��5;      $��50��6#    �� 
IsEditable . $��Center=�5<      5=      5>      o� 5?   
   $��0��6   $��0��6   #���   5@      $��25��5A      $��Right=�5B      .@�5C      '   !WPFCustomControls.MyCustomControl  -   5          Name$ customControl��5C   &   '   !WPFCustomControls.MyCustomControl   Click$ customControl_Click��5E   &   $��Custom button��5C   ?   $��85��5D   &   $��25��63   5E   &   m� 5F      -   5        $��Сhange style��5F      $��25��5G        menuItem#��[ 5H      5I      �� 5K   
   -   5        	 ��Name$	 	rtbEditor��5K      $��0��5L      $��1��6&   
 �� AcceptsReturn
 .  �� 
LineHeight$ 6��5M   +    �� 	IsEnabled .  � Language$ en-us�5N   2   5O      �� 5P   
   $��0��6   $��2��6!   $��Center=�6.   ._�5Q      �� -   5         ��Name$ tbNumSimbols��5Q      $��Center=�6.   5R      5S      5T      