   M S B A M L   `   `   `  ����D  @WPFTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFTester	WPFTester  5   	   %clr-namespace:WPFTester	WPFTester  5   	   /clr-namespace:WPFTester.ViewWPFTester.View  5   	       WPFTester.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFTester     5   	   )modelclr-namespace:WPFTester     5   	   -Viewclr-namespace:WPFTester.View     5   	     � Title$  
MainWindow��5
   	   $	��850��6   $	��800��6)   .��5      �� .+�5   
      WPFTester.View.MainView  � 5   
   $	��100��6   .+�5       �� ��6   �� *
Elements+5!      �� 5#   
   aa ------------------5$      �� 5%   
   $	��100��64   ��6   �� *
BacItems+��5&      �� 5'       �� DataType$ x:Type local:BacItem��6   .R�5(      �� .+�5)      �� ��6$   ��  �� Path$	 Nom��� 5*      ��6$   �� *Nom+�� 5+      ��6$   �� *Desc+5,      5-      50      �� 52   
   bb53      �� 5B   
   cc5C      �� 5D   
   -   5         ��Name$
 lbCC��5D   7   $	��400��6   $	��100��6   $��10q�6+   ��6E   �� *
BacItems+��5E      �� 5F      $ x:Type local:BacItem��6   .R�5G      �� .+�5H      �� ��6$   �� *Nom+5I      5J      5L      �� 5N   
   dd5O      �� 5P   
   -   5        $
 lbDD��5P   7   $	��400��6   $	��100��6   $��10q�6+   ��6E   ��  �� Source$ items����5Q      �� 5R      $ x:Type local:BacItem��6   .R�5S      �� .+�5T      �� ��6$   �� $	 Num��� 5U      ��6$   �� $	 Nom��� 5V      $	��oo ��6$   5W      5X      5Z      �� 5\   
   ooo6   �� 5]   
   -   5        $��Master��5]      $��2��6    $��3��6-   $��8q�6A   $	��100��6L   ��5^      �� *listingDataView+ �� Mode$ TwoWay=���5d      �� 5e      $ x:Type local:BacItem��6   .R�5f      �� .+�5g      �� $��xx��6$   �� 5h      ��6$   �� $	 Nom��� 5i      ��6$   �� $
 Desc��� 5j      ��6$   �� $	 Num�5k      5l      5n      5q      5r      