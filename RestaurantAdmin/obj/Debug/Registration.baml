   M S B A M L   `   `   `  ����J  FRestaurantAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:RestaurantAdminRestaurantAdmin  5   	   "    RestaurantAdmin.Registration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:RestaurantAdmin     5   	     � Title$  Registration��5   	   $	��700��6   $
��1000��6+    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]    � Icon$7 1Icons-Land-Points-Of-Interest-Restaurant-Blue.ico��6s   ��5	      �� 5
   
    �� ImageSource$ restaurant.jpg��6    �� Opacity$	 0.6Q�62   .��5      � .+�5   
   � $
��Left=�6   $��530               ��6*   $��
10,130,0,0q�5      $	��Top=�6%   $	��974��6=   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   $	 0.8Q�6J   .��5      �  � Color$ White��6#   	 � Offset$	 0Q�61   � 5      $ Black��6#   $	 1Q�61   5      .+�5      �� -   5        
 ��Name$
 
label_Copy��5      $��Registration��6(   $��Center=�6?   $��
10,10,10,0q�6\   $	��Top=�6p    J� RenderTransformOrigin$ -0.19,-0.879&�6�   $	��419��6�   $��Center=�6�   $��48(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6  
�������6  �� 5      -   5        $
 label_Copy2��5      $��	Username:��6)   $��Center=�6=   $��10,134,545,0q�6Z   $	��Top=�6p   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   �� 5      -   5         ��Name$ 	useradmin��5      $
��Left=�6)   $��40��6D   $��
10,192,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   �� 5      -   5        $
 label_Copy3��5      $��	Password:��6)   $��Center=�6=   $��10,272,545,0q�6Z   $	��Top=�6p   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   G� 5      -   5         G�Name$ passwordregister��5      $
��Left=�64   $��
10,330,0,0q�6O   $	��Top=�6c   $��40��6{   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   �� 5      -   5         ��Name$ buttonadmin��5      $��Register��6*   $
��Left=�6=   $��817,470,0,0q�6X   $	��Top=�6m   $	��147��6�   $��50��6�   $��26.667(�6�   $��Lucida Calligraphy)�6�   6�   �� 5      -   5        $
 label_Copy1��5      $��Email:��6)   $��Center=�6:   $��545,134,10,0q�6W   $	��Top=�6m   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   �� 5      -   5        $ emailRegister��5      $
��Left=�6-   $��40��6H   $��545,192,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   �� 5      -	   5        $
 label_Copy4��5      $��
Telephone:��6)   $��Center=�6>   $��545,272,10,0q�6[   $	��Top=�6q   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   �� 5      -
   5        $ telephoneregister��5      $
��Left=�61   $��40��6L   $��545,330,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   �� 5      -   5        $
 label_Copy5��5      $��Address:��6)   $��Center=�6<   $��11,412,544,0q�6Y   $	��Top=�6o   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   �� 5       -   5        $ addressregister��5       $
��Left=�6/   $��40��6J   $��
10,470,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   �� 5!      -   5        $
 label_Copy6��5!      $��	Username:��6)   $��Center=�6=   $��10.2,134,544.8,0q�6Z   $	��Top=�6t   $ -0.19,-0.879&�6�   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   
�������6�   �� 5"      -   5        $ usernameRegister��5"      $
��Left=�60   $��40��6K   $��
10,192,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��419��6�   $��32(�6�   $��Lucida Calligraphy)�6�   5#      o� 5$   
   -   5         o�Name$
 menu��5$      $
��Left=�6   $��30��68   $	��Top=�6D   $	��994��6\   $��
0,0,-0.4,0q�6h   .@�5%      �� -   5        $
��Exit��5%      $��35��6$   ���	#FFF0F0F0$ -1.608,-0.131&�6^   $��30��6�   ��6�   Z� 6�   �� 5&      -   5        $
��Info��5&      $��34��6$   ���	#FFF0F0F0$��30��6`   ��5'      �� 5(      5*      5+      5,      5-      