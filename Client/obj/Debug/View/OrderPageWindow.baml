   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Client.ViewClient.View  5   	   !    Client.View.OrderPageWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Client.View     5   	     � Title$  OrderPageWindow��5   	   $	��600��6!   $	��800��61   
������� � WindowStartupLocation$ CenterScreen=�6W   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��40 �6   �� 5      $	��160 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��
BackButton��5      $��0��6#   $	��Top=�63   $
��Left=�6K   $��40��6f   $��40��6r   
������� � UseLayoutRounding . 
�������.��5      �� $e��_C:\Users\Alexandr\Documents\GitHub\GroupProjectCSharp\CSharpShop\Client\Resources/LeftArrow.jpg��6   6�   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $	��23* �6    �� 5      $
��145* �6    �� 5      $
��168* �6    �� 5      $
��168* �6    .+�5      �� $��1��6   $��Add to cart��6"   $��Center=�69   $��50��6T   $��10,36,10,59q�6`   ���	#FF69D7F76u   �� 5      $��2��6   $��
Save order��6"   $��Center=�67   $��50��6R   $��10,59q�6^   ���	#FF69D7F76m   �� 5      $��3��6   $��Delete product from cart��6"   $��Center=�6E   $��50��6`   $��10,59q�6l   ���	#FF69D7F76{   5      � 5   
   $��2��6    5      �� 5       $
��auto �6    $	��300��6/   �� 5!      $��* �6    �� 5"      $
��auto �6    .+�5$      9� -   5        $��ProductsInOrderExpander��5$      $��0��66   $��All products��6C   $	��300��6Y    9� 
IsExpanded . .��5%      �� -   5        $��ProductListView��5%      $��Visible=�63   5&      � 5'      $��1��6    5(      �� 5)      $��40 �6$   �� 5*      $��* �6$   .+�5,      �� $��	Your cart��6   $��Center=�6-   $��20(�6J   �� 5-      $��1��6   5.      � 5/      $��2��6    50      �� 51      �� 52      .+�54      �� $��Order amount:��6   $��0��60   $��Right=�6@   $��20(�6\   �� 55      $
��100$��6   $��1��6'   $
��Left=�67   $��20(�6R   56      58      59      5:      