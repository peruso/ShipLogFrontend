class Reviews extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            data: []
        };
    }
    componentDidMount() {
        $.ajax({
            url: ShipReviewsURL,
            type: "GET",
            dataType: "json",
            success: function (returnData) {
                if (returnData != null) {
                    this.setState({ data: returnData });
                    console.log(returnData);
                }
            }.bind(this),
            error: function (jqRequest, status, error) {
                console.log(status);
                console.log(jqRequest);
                console.log(error);
            }
        });
    }
    render() {
        function makeShipReviewList(x, index) {
            return <ShipReview key={index} data={x} />
        }
        return (
            <div >

                {this.state.data.map(makeShipReviewList)}
            </div>
        );
    }
}